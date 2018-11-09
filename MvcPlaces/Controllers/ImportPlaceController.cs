using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcPlaces.Code.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.Controllers
{
    public class ImportPlaceController :
        ImportController<ModelsImport.Place,
                             ViewModels.Models.Import.PlaceView,
                             Models.Place,
                             ViewModels.Models.Main.PlaceView>
    {
        #region List

        public async override Task<IActionResult> Index()
        {
            return await base.Index();
        }

        public async override Task<IActionResult> ListImported()
        {
            return await base.ListImported();
        }

        public async override Task<IActionResult> ListNotImported()
        {
            return await base.ListNotImported();
        }

        #endregion List

        #region Import

        public async override Task<IActionResult> Import(int? id)
        {
            return await base.Import(id);
        }

        [HttpPost, ActionName("Import")]
        [ValidateAntiForgeryToken]
        public async override Task<IActionResult> ImportConfirmed(int id)
        {
            return await base.ImportConfirmed(id);
        }

        public async override Task<IActionResult> QuickImport(int? id)
        {
            return await base.QuickImport(id);
        }

        #endregion Import

        #region CannotImport

        public async override Task<IActionResult> CannotImport(int? id)
        {
            return await base.CannotImport(id);
        }

        [HttpPost, ActionName("CannotImport")]
        [ValidateAntiForgeryToken]
        public override ActionResult CannotImportConfirmed(int id)
        {
            return base.CannotImportConfirmed(id);
        }

        #endregion CannotImport

        #region Delete

        public async override Task<IActionResult> Delete(int? id)
        {
            return await base.Delete(id);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async override Task<IActionResult> DeleteConfirmed(int id)
        {
            return await base.DeleteConfirmed(id);
        }

        #endregion Delete

        #region Override Abstract Methods

        protected override DataAccess<Models.Place, ViewModels.Models.Main.PlaceView> LoadImportToDataAccess()
        {
            return new DataAccess<Models.Place, ViewModels.Models.Main.PlaceView>(ImportToContext, ImportToContext.Place);
        }

        protected override DataAccess<ModelsImport.Place, ViewModels.Models.Import.PlaceView> LoadDataAccess()
        {
            return new DataAccess<ModelsImport.Place, ViewModels.Models.Import.PlaceView>(ImportFromContext, ImportFromContext.Place);
        }

        protected override bool ImportItem(ModelsImport.Place item)
        {
            if (item.Region.ImportId.HasValue)
            {
                //Create the new item
                Models.Place newItem = new Models.Place();

                newItem.Name = item.Name;
                newItem.LocalName = "XX"; //A default value.
                newItem.Latitude = item.Latitude;
                newItem.Longitude = item.Longitude;
                newItem.Zoom = 10; //A default value

                ImportToDataAccess.Add(newItem);
                ImportToDataAccess.Save();

                //Update the old / import item with the import Id
                item.ImportId = newItem.Id;

                DataAccess.Update(item);
                DataAccess.Save();

                //Create a Territory Place object
                Models.TerritoryPlace newJoin = new Models.TerritoryPlace();
                newJoin.PlaceId = newItem.Id;
                newJoin.TerritoryId = item.Region.ImportId.Value;

                ImportToJoinDataAccess.Add(newJoin);
                ImportToDataAccess.Save();

                return true;
            }
            else
            {
                return false;
            }
        }

        protected override Func<int, ModelsImport.Place> GetItemFunction()
        {
            return i => ImportFromContext.Place
                        .Include(x => x.Region)
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<ModelsImport.Place>> GetItemsFunction()
        {
            return () => ImportFromContext.Place
                        .Include(x => x.Region);
        }

        protected override Func<ModelsImport.Place, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods

        #region Properties

        private DataAccess<Models.TerritoryPlace, ViewModels.Models.Main.TerritoryPlaceView> importToJoinDataAccess = null;

        public DataAccess<Models.TerritoryPlace, ViewModels.Models.Main.TerritoryPlaceView> ImportToJoinDataAccess
        {
            get => importToJoinDataAccess ?? (importToJoinDataAccess = new DataAccess<Models.TerritoryPlace, ViewModels.Models.Main.TerritoryPlaceView>(ImportToContext, ImportToContext.TerritoryPlace));
            set => importToJoinDataAccess = value;
        }

        #endregion Properties
    }
}
