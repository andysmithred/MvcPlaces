using Microsoft.AspNetCore.Mvc;
using MvcPlaces.Code.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.Controllers
{
    public class ImportPlaceGroupController :
        ImportController<ModelsImport.PlaceGroup,
                             ViewModels.Models.Import.PlaceGroupView,
                             Models.PlaceGroup,
                             ViewModels.Models.Main.PlaceGroupView>
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

        protected override DataAccess<Models.PlaceGroup, ViewModels.Models.Main.PlaceGroupView> LoadImportToDataAccess()
        {
            return new DataAccess<Models.PlaceGroup, ViewModels.Models.Main.PlaceGroupView>(ImportToContext, ImportToContext.PlaceGroup);
        }

        protected override DataAccess<ModelsImport.PlaceGroup, ViewModels.Models.Import.PlaceGroupView> LoadDataAccess()
        {
            return new DataAccess<ModelsImport.PlaceGroup, ViewModels.Models.Import.PlaceGroupView>(ImportFromContext, ImportFromContext.PlaceGroup);
        }

        protected override bool ImportItem(ModelsImport.PlaceGroup item)
        {
            //Create the new item
            Models.PlaceGroup newItem = new Models.PlaceGroup();

            newItem.Name = item.Name;
            newItem.Description = item.Description;

            ImportToDataAccess.Add(newItem);
            ImportToDataAccess.Save();

            //Update the old / import item with the import Id
            item.ImportId = newItem.Id;

            DataAccess.Update(item);
            DataAccess.Save();

            return true;
        }

        protected override Func<int, ModelsImport.PlaceGroup> GetItemFunction()
        {
            return i => ImportFromContext.PlaceGroup.FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<ModelsImport.PlaceGroup>> GetItemsFunction()
        {
            return () => ImportFromContext.PlaceGroup;
        }

        protected override Func<ModelsImport.PlaceGroup, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods
    }
}