using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcPlaces.Code.Data;

namespace MvcPlaces.Controllers
{
    public class ImportLegController :
        ImportController<ModelsImport.Leg,
                             ViewModels.Models.Import.LegView,
                             Models.RouteLeg,
                             ViewModels.Models.Main.RouteLegView>
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

        protected override DataAccess<Models.RouteLeg, ViewModels.Models.Main.RouteLegView> LoadImportToDataAccess()
        {
            return new DataAccess<Models.RouteLeg, ViewModels.Models.Main.RouteLegView>(ImportToContext, ImportToContext.RouteLeg);
        }

        protected override DataAccess<ModelsImport.Leg, ViewModels.Models.Import.LegView> LoadDataAccess()
        {
            return new DataAccess<ModelsImport.Leg, ViewModels.Models.Import.LegView>(ImportFromContext, ImportFromContext.Leg);
        }

        protected override bool ImportItem(ModelsImport.Leg item)
        {
            //Create the new item
            Models.RouteLeg newItem = new Models.RouteLeg();

            newItem.Number = item.Number;
            newItem.Description = item.Description;

            newItem.RouteId = item.Route.ImportId.Value;

            newItem.DestinationId = item.DestinationAirfield.ImportId.Value;
            newItem.OriginId = item.OriginAirfield.ImportId.Value;

            ImportToDataAccess.Add(newItem);
            ImportToDataAccess.Save();

            //Update the old / import item with the import Id
            item.ImportId = newItem.Id;

            DataAccess.Update(item);
            DataAccess.Save();

            return true;
        }

        protected override Func<int, ModelsImport.Leg> GetItemFunction()
        {
            return i => ImportFromContext
                        .Leg
                        .Include(x => x.Route)
                        .Include(x => x.OriginAirfield)
                        .Include(x => x.DestinationAirfield)
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<ModelsImport.Leg>> GetItemsFunction()
        {
            return () => ImportFromContext
                        .Leg
                        .Include(x => x.Route)
                        .Include(x => x.OriginAirfield)
                        .Include(x => x.DestinationAirfield);
        }

        protected override Func<ModelsImport.Leg, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods
    }
}
