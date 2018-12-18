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
    public class DriveLegController : TravelController<DriveLeg, DriveLegView>
    {
        #region Private Declarations

        private DataAccess<Drive, DriveView> drives = null;
        private ICollection<DriveView> drivesList = null;

        private DataAccess<Place, PlaceView> places = null;
        private ICollection<PlaceView> placesList = null;

        #endregion Private Declarations

        #region Public Properties

        public DataAccess<Drive, DriveView> Drives
        {
            get => drives ?? (drives = new DataAccess<Drive, DriveView>(Context, Context.Drive));
            set => drives = value;
        }

        public ICollection<DriveView> DrivesList
        {
            get => drivesList ?? (drivesList = Drives.GetViews().OrderBy(x => x.ListName).ToList());
            set => drivesList = value;
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

        public DriveLegController(TravelContext context)
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
            ViewBag.Drives = GetSelectList<DriveView>(DrivesList, null);
            ViewBag.Origins = GetSelectList<PlaceView>(PlacesList, null);
            ViewBag.Destinations = GetSelectList<PlaceView>(PlacesList, null);
            return base.Create();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Number,DriveId,OriginId,DestinationId,Description")] DriveLeg item)
        {
            if (ModelState.IsValid)
            {
                await AddAsync(item);
                return RedirectToAction("Details", new { id = item.Id });
            }
            ViewBag.Drives = GetSelectList<DriveView>(DrivesList, item.DriveId);
            ViewBag.Origins = GetSelectList<PlaceView>(PlacesList, item.OriginId);
            ViewBag.Destinations = GetSelectList<PlaceView>(PlacesList, item.DestinationId);
            return View(item);
        }

        #endregion Create

        #region Edit

        public override async Task<IActionResult> Edit(int? id)
        {
            IActionResult result = await base.Edit(id);
            ViewBag.Drives = GetSelectList<DriveView>(DrivesList, Item.DriveId);
            ViewBag.Origins = GetSelectList<PlaceView>(PlacesList, Item.OriginId);
            ViewBag.Destinations = GetSelectList<PlaceView>(PlacesList, Item.DestinationId);
            return result;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public override async Task<IActionResult> Edit(int id, [Bind("Id,Number,DriveId,OriginId,DestinationId,Description")] DriveLeg item)
        {
            IActionResult result = await base.Edit(id, item);
            ViewBag.Drives = GetSelectList<DriveView>(DrivesList, item.DriveId);
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

        protected override DataAccess<DriveLeg, DriveLegView> LoadDataAccess()
        {
            return new DataAccess<DriveLeg, DriveLegView>(Context, Context.DriveLeg);
        }

        protected override Func<int, DriveLeg> GetItemFunction()
        {
            return i => Context.DriveLeg
                        .Include(x => x.Drive)
                        .Include(x => x.Origin)
                        .Include(x => x.Destination)
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<DriveLeg>> GetItemsFunction()
        {
            return () => Context.DriveLeg
                        .Include(x => x.Drive)
                        .Include(x => x.Origin)
                        .Include(x => x.Destination);
        }

        protected override Func<DriveLeg, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods
    }
}