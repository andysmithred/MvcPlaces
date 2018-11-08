using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcPlaces.Code.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.Controllers
{
    public class ImportCountryController : 
            ImportController<ModelsImport.Country,
                             ViewModels.Models.Import.CountryView,
                             Models.Territory,
                             ViewModels.Models.Main.TerritoryView>
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

        protected override DataAccess<Models.Territory, ViewModels.Models.Main.TerritoryView> LoadImportToDataAccess()
        {
            return new DataAccess<Models.Territory, ViewModels.Models.Main.TerritoryView>(ImportToContext, ImportToContext.Territory);
        }

        protected override DataAccess<ModelsImport.Country, ViewModels.Models.Import.CountryView> LoadDataAccess()
        {
            return new DataAccess<ModelsImport.Country, ViewModels.Models.Import.CountryView>(ImportFromContext, ImportFromContext.Country);
        }

        protected override bool ImportItem(ModelsImport.Country item)
        {
            if (item.Continent.ImportId.HasValue)
            {
                //Create the new item
                Models.Territory newItem = new Models.Territory();

                newItem.Name = item.Name;
                newItem.FullName = item.FullName;
                newItem.NativeName = "XX"; //A default value.
                newItem.ContinentId = item.Continent.ImportId.Value;
                newItem.Population = item.Population;
                newItem.Area = item.Area;
                newItem.Isocode = item.Isocode;
                newItem.Latitude = item.Latitude;
                newItem.Longitude = item.Longitude;
                newItem.Zoom = item.Zoom;
                newItem.TerritoryTypeId = ImportToContext.TerritoryType.Where(x => x.Type == "Default").FirstOrDefault().Id;

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

        protected override Func<int, ModelsImport.Country> GetItemFunction()
        {
            return i => ImportFromContext.Country
                        .Include(x => x.Continent)
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<ModelsImport.Country>> GetItemsFunction()
        {
            return () => ImportFromContext.Country
                        .Include(x => x.Continent);
        }

        protected override Func<ModelsImport.Country, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods
    }
}
