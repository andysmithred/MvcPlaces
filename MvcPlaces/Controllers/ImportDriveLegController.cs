using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcPlaces.Code.Data;

namespace MvcPlaces.Controllers
{
    public class ImportDriveLegController :
        ImportController<ModelsImport.DriveLeg,
                             ViewModels.Models.Import.DriveLegView,
                             Models.DriveLeg,
                             ViewModels.Models.Main.DriveLegView>
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

        protected override DataAccess<Models.DriveLeg, ViewModels.Models.Main.DriveLegView> LoadImportToDataAccess()
        {
            return new DataAccess<Models.DriveLeg, ViewModels.Models.Main.DriveLegView>(ImportToContext, ImportToContext.DriveLeg);
        }

        protected override DataAccess<ModelsImport.DriveLeg, ViewModels.Models.Import.DriveLegView> LoadDataAccess()
        {
            return new DataAccess<ModelsImport.DriveLeg, ViewModels.Models.Import.DriveLegView>(ImportFromContext, ImportFromContext.DriveLeg);
        }

        protected override bool ImportItem(ModelsImport.DriveLeg item)
        {
            //Create the new item
            Models.DriveLeg newItem = new Models.DriveLeg();

            newItem.Number = item.Number;
            newItem.Description = item.Description;

            newItem.DriveId = item.Drive.ImportId.Value;

            newItem.DestinationId = item.Destination.ImportId.Value;
            newItem.OriginId = item.Origin.ImportId.Value;

            ImportToDataAccess.Add(newItem);
            ImportToDataAccess.Save();

            //Update the old / import item with the import Id
            item.ImportId = newItem.Id;

            DataAccess.Update(item);
            DataAccess.Save();

            return true;
        }

        protected override Func<int, ModelsImport.DriveLeg> GetItemFunction()
        {
            return i => ImportFromContext
                        .DriveLeg
                        .Include(x => x.Drive)
                        .Include(x => x.Origin)
                        .Include(x => x.Destination)
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<ModelsImport.DriveLeg>> GetItemsFunction()
        {
            return () => ImportFromContext
                        .DriveLeg
                        .Include(x => x.Drive)
                        .Include(x => x.Origin)
                        .Include(x => x.Destination);
        }

        protected override Func<ModelsImport.DriveLeg, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods
    }
}