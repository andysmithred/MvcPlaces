using Microsoft.AspNetCore.Mvc;
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
    public class PlaceGroupSetController : TravelController<PlaceGroupSet, PlaceGroupSetView>
    {
        #region Private Declarations

        private DataAccess<Place, PlaceView> places = null;
        private ICollection<PlaceView> placesList = null;

        private DataAccess<PlaceGroup, PlaceGroupView> placeGroups = null;
        private ICollection<PlaceGroupView> placeGroupsList = null;

        #endregion Private Declarations

        #region Public Properties

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

        public DataAccess<PlaceGroup, PlaceGroupView> PlaceGroups
        {
            get => placeGroups ?? (placeGroups = new DataAccess<PlaceGroup, PlaceGroupView>(Context, Context.PlaceGroup));
            set => placeGroups = value;
        }

        public ICollection<PlaceGroupView> PlaceGroupsList
        {
            get => placeGroupsList ?? (placeGroupsList = PlaceGroups.GetViews().OrderBy(x => x.ListName).ToList());
            set => placeGroupsList = value;
        }

        #endregion Public Properties

        #region Constructor

        public PlaceGroupSetController(TravelContext context)
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
            ViewBag.Places = GetSelectList<PlaceView>(PlacesList, null);
            ViewBag.PlaceGroups = GetSelectList<PlaceGroupView>(PlaceGroupsList, null);
            return base.Create();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GroupId,PlaceId")] PlaceGroupSet item)
        {
            if (ModelState.IsValid)
            {
                await AddAsync(item);
                return RedirectToAction("Details", new { id = item.Id });
            }
            ViewBag.Places = GetSelectList<PlaceView>(PlacesList, item.PlaceId);
            ViewBag.PlaceGroups = GetSelectList<PlaceGroupView>(PlaceGroupsList, item.GroupId);
            return View(item);
        }

        public IActionResult CreateByPlace(int id)
        {
            ViewBag.Places = GetSelectList<PlaceView>(PlacesList, id);
            ViewBag.PlaceGroups = GetSelectList<PlaceGroupView>(PlaceGroupsList, null);
            ViewBag.Place = id;
            return base.Create();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateByPlace([Bind("GroupId,PlaceId")] PlaceGroupSet item)
        {
            if (ModelState.IsValid)
            {
                await AddAsync(item);
                return RedirectToAction("Details", "Place", new { id = item.PlaceId });
            }
            ViewBag.Places = GetSelectList<PlaceView>(PlacesList, item.PlaceId);
            ViewBag.PlaceGroups = GetSelectList<PlaceGroupView>(PlaceGroupsList, item.GroupId);
            ViewBag.Place = item.PlaceId;
            return View(item);
        }

        public IActionResult CreateByPlaceGroup(int id)
        {
            ViewBag.Places = GetSelectList<PlaceView>(PlacesList, null);
            ViewBag.PlaceGroups = GetSelectList<PlaceGroupView>(PlaceGroupsList, id);
            ViewBag.PlaceGroup = id;
            return base.Create();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateByPlaceGroup([Bind("GroupId,PlaceId")] PlaceGroupSet item)
        {
            if (ModelState.IsValid)
            {
                await AddAsync(item);
                return RedirectToAction("Detailsyyy", new { id = item.Id });
            }
            ViewBag.Places = GetSelectList<PlaceView>(PlacesList, item.PlaceId);
            ViewBag.PlaceGroups = GetSelectList<PlaceGroupView>(PlaceGroupsList, item.GroupId);
            ViewBag.PlaceGroup = item.GroupId;
            return View(item);
        }

        #endregion Create

        #region Edit

        public override async Task<IActionResult> Edit(int? id)
        {
            IActionResult result = await base.Edit(id);
            ViewBag.Places = GetSelectList<PlaceView>(PlacesList, Item.PlaceId);
            ViewBag.PlaceGroups = GetSelectList<PlaceGroupView>(PlaceGroupsList, Item.GroupId);
            return result;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public override async Task<IActionResult> Edit(int id, [Bind("Id,GroupId,PlaceId")] PlaceGroupSet item)
        {
            IActionResult result = await base.Edit(id, item);
            ViewBag.Places = GetSelectList<PlaceView>(PlacesList, item.PlaceId);
            ViewBag.PlaceGroups = GetSelectList<PlaceGroupView>(PlaceGroupsList, item.GroupId);
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

        protected override DataAccess<PlaceGroupSet, PlaceGroupSetView> LoadDataAccess()
        {
            return new DataAccess<PlaceGroupSet, PlaceGroupSetView>(Context, Context.PlaceGroupSet);
        }

        protected override Func<int, PlaceGroupSet> GetItemFunction()
        {
            return i => Context.PlaceGroupSet
                        .Include(x => x.Group)
                        .Include(x => x.Place)
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<PlaceGroupSet>> GetItemsFunction()
        {
            return () => Context.PlaceGroupSet
                        .Include(x => x.Group)
                        .Include(x => x.Place);
        }

        protected override Func<PlaceGroupSet, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods
    }
}
