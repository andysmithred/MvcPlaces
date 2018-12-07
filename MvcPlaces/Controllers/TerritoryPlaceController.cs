using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcPlaces.Code.Data;
using MvcPlaces.Models;
using MvcPlaces.ViewModels.Models.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.Controllers
{
    public class TerritoryPlaceController : TravelController<TerritoryPlace, TerritoryPlaceView>
    {
        #region Private Declarations

        private DataAccess<Territory, TerritoryView> territories = null;
        private ICollection<TerritoryView> territoriesList = null;

        private DataAccess<Place, PlaceView> places = null;
        private ICollection<PlaceView> placesList = null;

        #endregion Private Declarations

        #region Public Properties

        public DataAccess<Territory, TerritoryView> Territories
        {
            get => territories ?? (territories = new DataAccess<Territory, TerritoryView>(Context, Context.Territory));
            set => territories = value;
        }

        public ICollection<TerritoryView> TerritoriesList
        {
            get => territoriesList ?? (territoriesList = Territories.GetViews().OrderBy(x => x.ListName).ToList());
            set => territoriesList = value;
        }

        public DataAccess<Place, PlaceView> Places
        {
            get => places ?? (places = new DataAccess<Place, PlaceView>(Context, Context.Place));
            set => places = value;
        }

        public ICollection<PlaceView> PlacesList
        {
            get => placesList ?? (placesList = Places.GetViews().OrderBy(x => x.ListName).ToList());
            set => placesList = value;
        }

        #endregion Public Properties

        #region Constructor

        public TerritoryPlaceController(TravelContext context)
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

        #endregion Details

        #region Create

        public override IActionResult Create()
        {
            ViewBag.Territories = GetTerritoriesSelectList(null);
            ViewBag.Places = GetPlacesSelectList(null);
            return base.Create();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TerritoryId,PlaceId")] TerritoryPlace item)
        {
            if (ModelState.IsValid)
            {
                await AddAsync(item);
                return RedirectToAction("Details", new { id = item.Id });
            }
            ViewBag.Territories = GetTerritoriesSelectList(item.TerritoryId);
            ViewBag.Places = GetPlacesSelectList(item.PlaceId);
            return View(item);
        }

        public IActionResult CreateByPlace(int id)
        {
            ViewBag.Territories = GetTerritoriesSelectList(null);
            ViewBag.Places = GetPlacesSelectList(id);
            ViewBag.Place = id;
            return base.Create();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateByPlace([Bind("TerritoryId,PlaceId")] TerritoryPlace item)
        {
            if (ModelState.IsValid)
            {
                await AddAsync(item);
                return RedirectToAction("Details", "Place", new { id = item.PlaceId });
            }
            ViewBag.Territories = GetTerritoriesSelectList(item.TerritoryId);
            ViewBag.Places = GetPlacesSelectList(item.PlaceId);
            ViewBag.Place = item.PlaceId;
            return View(item);
        }

        public IActionResult CreateByTerritory(int id)
        {
            ViewBag.Territories = GetTerritoriesSelectList(id);
            ViewBag.Places = GetPlacesSelectList(null);
            ViewBag.Territory = id;
            return base.Create();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateByTerritory([Bind("TerritoryId,PlaceId")] TerritoryPlace item)
        {
            if (ModelState.IsValid)
            {
                await AddAsync(item);
                return RedirectToAction("Details", "Territory", new { id = item.TerritoryId });
            }
            ViewBag.Territories = GetTerritoriesSelectList(item.TerritoryId);
            ViewBag.Places = GetPlacesSelectList(item.PlaceId);
            ViewBag.Territory = item.TerritoryId;
            return View(item);
        }

        #endregion Create

        #region Edit

        public override async Task<IActionResult> Edit(int? id)
        {
            IActionResult result = await base.Edit(id);
            ViewBag.Territories = GetTerritoriesSelectList(Item.TerritoryId);
            ViewBag.Places = GetPlacesSelectList(Item.PlaceId);
            return result;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public override async Task<IActionResult> Edit(int id, [Bind("Id,TerritoryId,PlaceId")] TerritoryPlace item)
        {
            IActionResult result = await base.Edit(id, item);
            ViewBag.Territories = GetTerritoriesSelectList(item.TerritoryId);
            ViewBag.Places = GetPlacesSelectList(item.PlaceId);
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

        protected override DataAccess<TerritoryPlace, TerritoryPlaceView> LoadDataAccess()
        {
            return new DataAccess<TerritoryPlace, TerritoryPlaceView>(Context, Context.TerritoryPlace);
        }

        protected override Func<int, TerritoryPlace> GetItemFunction()
        {
            return i => Context.TerritoryPlace
                        .Include(x => x.Territory).ThenInclude(x => x.Flag)
                        .Include(x => x.Territory).ThenInclude(x => x.Parent).ThenInclude(x => x.Flag)
                        .Include(x => x.Place)
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<TerritoryPlace>> GetItemsFunction()
        {
            return () => Context.TerritoryPlace
                        .Include(x => x.Territory)
                        .Include(x => x.Place);
        }

        protected override Func<TerritoryPlace, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods

        #region Select Lists

        public SelectList GetTerritoriesSelectList(int? id)
        {
            if (id.HasValue)
            {
                return new SelectList(TerritoriesList, "Id", "ListName", id);
            }
            else
            {
                return new SelectList(TerritoriesList, "Id", "ListName");
            }
        }

        public SelectList GetPlacesSelectList(int? id)
        {
            if (id.HasValue)
            {
                return new SelectList(PlacesList, "Id", "ListName", id);
            }
            else
            {
                return new SelectList(PlacesList, "Id", "ListName");
            }
        }

        #endregion Select Lists
    }
}
