using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcPlaces.Code.Data;
using MvcPlaces.Models;
using MvcPlaces.ViewModels.Models.Main;

namespace MvcPlaces.Controllers
{
    public class RouteLegController : TravelController<RouteLeg, RouteLegView>
    {
        #region Private Declarations

        private DataAccess<Route, RouteView> routes = null;
        private ICollection<RouteView> routesList = null;

        private DataAccess<Place, PlaceView> places = null;
        private ICollection<PlaceView> placesList = null;

        #endregion Private Declarations

        #region Public Properties

        public DataAccess<Route, RouteView> Routes
        {
            get => routes ?? (routes = new DataAccess<Route, RouteView>(Context, Context.Route));
            set => routes = value;
        }

        public ICollection<RouteView> RoutesList
        {
            get => routesList ?? (routesList = Routes.GetViews().OrderBy(x => x.ListName).ToList());
            set => routesList = value;
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

        public RouteLegController(TravelContext context)
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
            ViewBag.Routes = GetSelectList<RouteView>(RoutesList, null);
            ViewBag.Origins = GetSelectList<PlaceView>(PlacesList, null);
            ViewBag.Destinations = GetSelectList<PlaceView>(PlacesList, null);
            return base.Create();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Number,RouteId,OriginId,DestinationId,Description")] RouteLeg item)
        {
            if (ModelState.IsValid)
            {
                await AddAsync(item);
                return RedirectToAction("Details", new { id = item.Id });
            }
            ViewBag.Routes = GetSelectList<RouteView>(RoutesList, item.RouteId);
            ViewBag.Origins = GetSelectList<PlaceView>(PlacesList, item.OriginId);
            ViewBag.Destinations = GetSelectList<PlaceView>(PlacesList, item.DestinationId);
            return View(item);
        }

        #endregion Create

        #region Edit

        public override async Task<IActionResult> Edit(int? id)
        {
            IActionResult result = await base.Edit(id);
            ViewBag.Routes = GetSelectList<RouteView>(RoutesList, Item.RouteId);
            ViewBag.Origins = GetSelectList<PlaceView>(PlacesList, Item.OriginId);
            ViewBag.Destinations = GetSelectList<PlaceView>(PlacesList, Item.DestinationId);
            return result;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public override async Task<IActionResult> Edit(int id, [Bind("Id,Number,RouteId,OriginId,DestinationId,Description")] RouteLeg item)
        {
            IActionResult result = await base.Edit(id, item);
            ViewBag.Routes = GetSelectList<RouteView>(RoutesList, item.RouteId);
            ViewBag.Origins = GetSelectList<PlaceView>(PlacesList, item.OriginId);
            ViewBag.Destinations = GetSelectList<PlaceView>(PlacesList, item.DestinationId);
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

        protected override DataAccess<RouteLeg, RouteLegView> LoadDataAccess()
        {
            return new DataAccess<RouteLeg, RouteLegView>(Context, Context.RouteLeg);
        }

        protected override Func<int, RouteLeg> GetItemFunction()
        {
            return i => Context.RouteLeg
                        .Include(x => x.Route)
                        .Include(x => x.Origin)
                        .Include(x => x.Destination)
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<RouteLeg>> GetItemsFunction()
        {
            return () => Context.RouteLeg
                        .Include(x => x.Route)
                        .Include(x => x.Origin)
                        .Include(x => x.Destination);
        }

        protected override Func<RouteLeg, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods
    }
}
