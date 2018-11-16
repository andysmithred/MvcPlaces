using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcPlaces.Code.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.Controllers
{
    public class ImportPlaceGroupSetController :
        ImportController<ModelsImport.PlaceGroupSet,
                             ViewModels.Models.Import.PlaceGroupSetView,
                             Models.PlaceGroupSet,
                             ViewModels.Models.Main.PlaceGroupSetView>
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

        protected override DataAccess<Models.PlaceGroupSet, ViewModels.Models.Main.PlaceGroupSetView> LoadImportToDataAccess()
        {
            return new DataAccess<Models.PlaceGroupSet, ViewModels.Models.Main.PlaceGroupSetView>(ImportToContext, ImportToContext.PlaceGroupSet);
        }

        protected override DataAccess<ModelsImport.PlaceGroupSet, ViewModels.Models.Import.PlaceGroupSetView> LoadDataAccess()
        {
            return new DataAccess<ModelsImport.PlaceGroupSet, ViewModels.Models.Import.PlaceGroupSetView>(ImportFromContext, ImportFromContext.PlaceGroupSet);
        }

        protected override bool ImportItem(ModelsImport.PlaceGroupSet item)
        {
            if(item.Group.ImportId.HasValue && item.Place.ImportId.HasValue)
            {
                //Create the new item
                Models.PlaceGroupSet newItem = new Models.PlaceGroupSet();

                newItem.PlaceId = item.Place.ImportId.Value;
                newItem.GroupId = item.Group.ImportId.Value;

                ImportToDataAccess.Add(newItem);
                ImportToDataAccess.Save();

                //Update the old / import item with the import Id
                item.ImportId = newItem.Id;

                DataAccess.Update(item);
                DataAccess.Save();

                return true;
            }
            else
            {
                return false;
            }
        }

        protected override Func<int, ModelsImport.PlaceGroupSet> GetItemFunction()
        {
            return i => ImportFromContext.PlaceGroupSet
                        .Include(x => x.Place)
                        .Include(x => x.Group)
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<ModelsImport.PlaceGroupSet>> GetItemsFunction()
        {
            return () => ImportFromContext.PlaceGroupSet
                            .Include(x => x.Place)
                            .Include(x => x.Group);
        }

        protected override Func<ModelsImport.PlaceGroupSet, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods
    }
}
