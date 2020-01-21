using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcPlaces.Code.Data;

namespace MvcPlaces.Controllers
{
    public class ImportRouteController :
        ImportController<ModelsImport.Route,
                             ViewModels.Models.Import.RouteView,
                             Models.Route,
                             ViewModels.Models.Main.RouteView>
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

        protected override DataAccess<Models.Route, ViewModels.Models.Main.RouteView> LoadImportToDataAccess()
        {
            return new DataAccess<Models.Route, ViewModels.Models.Main.RouteView>(ImportToContext, ImportToContext.Route);
        }

        protected override DataAccess<ModelsImport.Route, ViewModels.Models.Import.RouteView> LoadDataAccess()
        {
            return new DataAccess<ModelsImport.Route, ViewModels.Models.Import.RouteView>(ImportFromContext, ImportFromContext.Route);
        }

        protected override bool ImportItem(ModelsImport.Route item)
        {
            //Create the new item
            Models.Route newItem = new Models.Route();

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

        protected override Func<int, ModelsImport.Route> GetItemFunction()
        {
            return i => ImportFromContext.Route
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<ModelsImport.Route>> GetItemsFunction()
        {
            return () => ImportFromContext.Route;
        }

        protected override Func<ModelsImport.Route, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods
    }
}