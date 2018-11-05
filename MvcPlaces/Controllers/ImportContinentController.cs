using Microsoft.AspNetCore.Mvc;
using MvcPlaces.Code.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.Controllers
{
    public class ImportContinentController : 
                    ImportController<ModelsImport.Continent, 
                                    ViewModels.Models.Import.ContinentView,
                                    Models.Continent, 
                                    ViewModels.Models.Main.ContinentView>
    {
        #region Override Abstract Methods

        protected override DataAccess<Models.Continent, ViewModels.Models.Main.ContinentView> LoadImportToDataAccess()
        {
            return new DataAccess<Models.Continent, ViewModels.Models.Main.ContinentView>(ImportToContext, ImportToContext.Continent);
        }

        protected override DataAccess<ModelsImport.Continent, ViewModels.Models.Import.ContinentView> LoadDataAccess()
        {
            return new DataAccess<ModelsImport.Continent, ViewModels.Models.Import.ContinentView>(ImportFromContext, ImportFromContext.Continent);
        }

        protected override bool ImportItem(ModelsImport.Continent item)
        {
            //Create the new Branch Type
            Models.Continent newItem = new Models.Continent();

            newItem.Name = item.Name;
            newItem.Code = item.Code;

            ImportToDataAccess.Add(newItem);
            ImportToDataAccess.Save();

            //Update the old / import item with the import Id
            item.ImportId = newItem.Id;

            DataAccess.Update(item);
            DataAccess.Save();

            return true;
        }

        protected override Func<int, ModelsImport.Continent> GetItemFunc()
        {
            return i => ImportFromContext.Continent
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<ModelsImport.Continent, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods

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
    }
}