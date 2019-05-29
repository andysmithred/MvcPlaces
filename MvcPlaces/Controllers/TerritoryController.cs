using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcPlaces.Code.Classes;
using MvcPlaces.Code.Data;
using MvcPlaces.Code.Enums;
using MvcPlaces.Models;
using MvcPlaces.ViewModels.Models.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.Controllers
{
    public class TerritoryController : TravelController<Territory, TerritoryView>
    {
        #region Private Declarations

        private DataAccess<Continent, ContinentView> continents = null;
        private ICollection<ContinentView> continentsList = null;

        private DataAccess<TerritoryType, TerritoryTypeView> territoryTypes = null;
        private ICollection<TerritoryTypeView> territoryTypesList = null;

        private DataAccess<Flag, FlagView> flags = null;
        private ICollection<FlagView> flagsList = null;

        #endregion Private Declarations

        #region Public Properties

        public DataAccess<Continent, ContinentView> Continents
        {
            get => continents ?? (continents = new DataAccess<Continent, ContinentView>(Context, Context.Continent));
            set => continents = value;
        }

        public ICollection<ContinentView> ContinentsList
        {
            get => continentsList ?? (continentsList = Continents.GetViews().OrderBy(x => x.ListName).ToList());
            set => continentsList = value;
        }

        public DataAccess<TerritoryType, TerritoryTypeView> TerritoryTypes
        {
            get => territoryTypes ?? (territoryTypes = new DataAccess<TerritoryType, TerritoryTypeView>(Context, Context.TerritoryType));
            set => territoryTypes = value;
        }

        public ICollection<TerritoryTypeView> TerritoryTypesList
        {
            get => territoryTypesList ?? (territoryTypesList = TerritoryTypes.GetViews().OrderBy(x => x.ListName).ToList());
            set => territoryTypesList = value;
        }

        public DataAccess<Flag, FlagView> Flags
        {
            get => flags ?? (flags = new DataAccess<Flag, FlagView>(Context, Context.Flag));
            set => flags = value;
        }

        public ICollection<FlagView> FlagsList
        {
            get => flagsList ?? (flagsList = Flags.GetViews().OrderBy(x => x.ListName).ToList());
            set => flagsList = value;
        }

        #endregion Public Properties

        #region Constructor

        public TerritoryController(TravelContext context)
            : base(context) { }

        #endregion Constructor

        #region Index

        public override async Task<IActionResult> Index()
        {
            return await base.Index();
        }

        #endregion Index

        #region Details

        public override async Task<IActionResult> Details(int? id)
        {
            return await base.Details(id);
        }

        public async Task<IActionResult> TerritoriesList(int? id)
        {
            return await base.Details(id);
        }

        public async Task<IActionResult> PlacesList(int? id)
        {
            return await base.Details(id);
        }

        #endregion Details

        #region Create

        public override IActionResult Create()
        {
            ViewBag.Continents = GetContinentsSelectList(null);
            ViewBag.TerritoryTypes = GetTerritoryTypesSelectList(null);
            ViewBag.Territories = GetTerritoriesSelectList(null);
            ViewBag.Flags = GetFlagsSelectList(null);
            ViewBag.GeoChartLevels = GetGeoChartLevelSelectList(string.Empty);

            return base.Create();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,FullName,NativeName,ContinentId,ParentId,Population,Area,Isocode,Latitude,Longitude,Zoom,TerritoryTypeId,GeoChartLevel,FlagId,Complete")] Territory item)
        {
            if (ModelState.IsValid)
            {
                await AddAsync(item);
                return RedirectToAction("Details", new { id = item.Id });
            }
            ViewBag.Continents = GetContinentsSelectList(item.ContinentId);
            ViewBag.TerritoryTypes = GetTerritoryTypesSelectList(item.TerritoryTypeId);
            ViewBag.Territories = GetTerritoriesSelectList(item.ParentId);
            ViewBag.Flags = GetFlagsSelectList(item.FlagId);
            ViewBag.GeoChartLevels = GetGeoChartLevelSelectList(item.GeoChartLevel);
            return View(item);
        }

        #endregion Create

        #region Edit

        public override async Task<IActionResult> Edit(int? id)
        {
            IActionResult result = await base.Edit(id);
            ViewBag.Continents = GetContinentsSelectList(Item.ContinentId);
            ViewBag.TerritoryTypes = GetTerritoryTypesSelectList(Item.TerritoryTypeId);
            ViewBag.Territories = GetTerritoriesSelectList(Item.ParentId);
            ViewBag.Flags = GetFlagsSelectList(Item.FlagId);
            ViewBag.GeoChartLevels = GetGeoChartLevelSelectList(Item.GeoChartLevel);
            return result;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public override async Task<IActionResult> Edit(int id, [Bind("Id,Name,FullName,NativeName,ContinentId,ParentId,Population,Area,Isocode,Latitude,Longitude,Zoom,TerritoryTypeId,GeoChartLevel,FlagId,Complete")] Territory item)
        {
            IActionResult result = await base.Edit(id, item);
            ViewBag.Continents = GetContinentsSelectList(item.ContinentId);
            ViewBag.TerritoryTypes = GetTerritoryTypesSelectList(item.TerritoryTypeId);
            ViewBag.Territories = GetTerritoriesSelectList(item.ParentId);
            ViewBag.Flags = GetFlagsSelectList(item.FlagId);
            ViewBag.GeoChartLevels = GetGeoChartLevelSelectList(item.GeoChartLevel);
            return result;
        }

        #endregion Edit

        #region Delete

        public override async Task<IActionResult> Delete(int? id)
        {
            return await base.Delete(id);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public override async Task<IActionResult> DeleteConfirmed(int id)
        {
            return await base.DeleteConfirmed(id);
        }

        #endregion Delete

        #region Override Abstract Methods

        protected override DataAccess<Territory, TerritoryView> LoadDataAccess()
        {
            return new DataAccess<Territory, TerritoryView>(Context, Context.Territory);
        }

        protected override Func<int, Territory> GetItemFunction()
        {
            return i => Context.Territory
                        .Include(x => x.Parent).ThenInclude(x => x.Continent)
                        .Include(x => x.Parent).ThenInclude(x => x.Flag)
                        .Include(x => x.Parent).ThenInclude(x => x.Parent).ThenInclude(x => x.Flag)
                        .Include(x => x.Children).ThenInclude(c => c.TerritoryType)
                        .Include(x => x.Children).ThenInclude(c => c.Flag)
                        .Include(x => x.Children).ThenInclude(c => c.Children)
                        .Include(x => x.Continent)
                        .Include(x => x.TerritoryType)
                        .Include(x => x.Flag)
                        .Include(x => x.TerritoryPlaces).ThenInclude(x => x.Place)
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<Territory>> GetItemsFunction()
        {
            return () => Context.Territory
                        .Include(x => x.Parent).ThenInclude(x => x.Continent)
                        .Include(x => x.Parent).ThenInclude(x => x.Flag)
                        .Include(x => x.Children).ThenInclude(c => c.TerritoryType)
                        .Include(x => x.Children).ThenInclude(c => c.Children)
                        .Include(x => x.Continent)
                        .Include(x => x.TerritoryType)
                        .Include(x => x.Flag)
                        .Include(x => x.TerritoryPlaces).ThenInclude(x => x.Place);
        }

        protected override Func<Territory, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods

        #region Select Lists

        public SelectList GetContinentsSelectList(int? id)
        {
            if(id.HasValue)
            {
                return new SelectList(ContinentsList, "Id", "ListName", id);
            }
            else
            {
                return new SelectList(ContinentsList, "Id", "ListName");
            }
        }

        public SelectList GetTerritoryTypesSelectList(int? id)
        {
            if (id.HasValue)
            {
                return new SelectList(TerritoryTypesList, "Id", "ListName", id);
            }
            else
            {
                return new SelectList(TerritoryTypesList, "Id", "ListName");
            }
        }

        public SelectList GetTerritoriesSelectList(int? id)
        {
            if (id.HasValue)
            {
                return new SelectList(DataAccess.GetViews().OrderBy(x => x.ListName), "Id", "ListName", id);
            }
            else
            {
                return new SelectList(DataAccess.GetViews().OrderBy(x => x.ListName), "Id", "ListName");
            }
        }

        public SelectList GetFlagsSelectList(int? id)
        {
            if (id.HasValue)
            {
                return new SelectList(FlagsList, "Id", "ListName", id);
            }
            else
            {
                return new SelectList(FlagsList, "Id", "ListName");
            }
        }

        public SelectList GetGeoChartLevelSelectList(string geoChartLevel)
        {
            if (String.IsNullOrEmpty(geoChartLevel))
            {
                return new SelectList(CommonFunctions.ConvertToStringList<GeoChartLevel>());
            }
            else
            {
                return new SelectList(CommonFunctions.ConvertToStringList<GeoChartLevel>(), geoChartLevel);
            }
        }

        #endregion Select Lists

    }
}
