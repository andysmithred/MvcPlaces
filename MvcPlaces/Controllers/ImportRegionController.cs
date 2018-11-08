using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcPlaces.Code.Data;
using MvcPlaces.ModelsImport;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.Controllers
{
    public class ImportRegionController :
        ImportController<ModelsImport.Region,
                             ViewModels.Models.Import.RegionView,
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

        protected override DataAccess<ModelsImport.Region, ViewModels.Models.Import.RegionView> LoadDataAccess()
        {
            return new DataAccess<ModelsImport.Region, ViewModels.Models.Import.RegionView>(ImportFromContext, ImportFromContext.Region);
        }

        protected override bool ImportItem(ModelsImport.Region item)
        {
            if (item.Country.ImportId.HasValue)
            {
                //Create the new item
                Models.Territory newItem = new Models.Territory();

                newItem.Name = item.Name;
                newItem.FullName = "XX"; //A default value.
                newItem.NativeName = "XX"; //A default value.
                newItem.ParentId = item.Country.ImportId.Value;
                newItem.Population = item.Population;
                newItem.Area = item.Area.HasValue ? (decimal?)item.Area : null;
                newItem.Isocode = item.Isocode;

                newItem.TerritoryTypeId = GetTerritoryType(item);

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

        protected override Func<int, ModelsImport.Region> GetItemFunction()
        {
            return i => ImportFromContext.Region
                        .Include(x => x.Country)
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<ModelsImport.Region>> GetItemsFunction()
        {
            return () => ImportFromContext.Region
                        .Include(x => x.Country);
        }

        protected override Func<ModelsImport.Region, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods

        #region Other Methods

        private int GetTerritoryType(Region item)
        {
            if(String.IsNullOrEmpty(item.Type))
            {
                return ImportToContext.TerritoryType.Where(x => x.Type == "Default").FirstOrDefault().Id;
            }

            var type = ImportToContext.TerritoryType.Where(x => x.Type.ToUpper() == item.Type.ToUpper()).FirstOrDefault();

            if(type == null)
            {
                return ImportToContext.TerritoryType.Where(x => x.Type == "Default").FirstOrDefault().Id;
            }
            else
            {
                return type.Id;
            }
        }

        #endregion Other Methods
    }
}
