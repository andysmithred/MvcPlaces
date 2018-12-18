using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcPlaces.Code.Data;

namespace MvcPlaces.Controllers
{
    public class ImportDriveController :
        ImportController<ModelsImport.Drive,
                             ViewModels.Models.Import.DriveView,
                             Models.Drive,
                             ViewModels.Models.Main.DriveView>
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

        protected override DataAccess<Models.Drive, ViewModels.Models.Main.DriveView> LoadImportToDataAccess()
        {
            return new DataAccess<Models.Drive, ViewModels.Models.Main.DriveView>(ImportToContext, ImportToContext.Drive);
        }

        protected override DataAccess<ModelsImport.Drive, ViewModels.Models.Import.DriveView> LoadDataAccess()
        {
            return new DataAccess<ModelsImport.Drive, ViewModels.Models.Import.DriveView>(ImportFromContext, ImportFromContext.Drive);
        }

        protected override bool ImportItem(ModelsImport.Drive item)
        {
            //Create the new item
            Models.Drive newItem = new Models.Drive();

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

        protected override Func<int, ModelsImport.Drive> GetItemFunction()
        {
            return i => ImportFromContext.Drive
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<ModelsImport.Drive>> GetItemsFunction()
        {
            return () => ImportFromContext.Drive;
        }

        protected override Func<ModelsImport.Drive, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods
    }
}