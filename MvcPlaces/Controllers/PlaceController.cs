using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcPlaces.Code.Data;
using MvcPlaces.Models;
using MvcPlaces.ViewModels.Models.Main;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.Controllers
{
    public class PlaceController : TravelController<Place, PlaceView>
    {
        #region Private Declarations

        #endregion Private Declarations

        #region Public Properties

        #endregion Public Properties

        #region Constructor

        public PlaceController(TravelContext context)
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

        #endregion Details

        #region Create

        public override IActionResult Create()
        {
            return base.Create();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,LocalName,Latitude,Longitude,Zoom")] Place item)
        {
            if (ModelState.IsValid)
            {
                await AddAsync(item);
                return RedirectToAction("Details", new { id = item.Id });
            }
            return View(item);
        }

        #endregion Create

        #region Edit

        public override async Task<IActionResult> Edit(int? id)
        {
            return await base.Edit(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public override async Task<IActionResult> Edit(int id, [Bind("Id,Name,LocalName,Latitude,Longitude,Zoom")] Place item)
        {
            return await base.Edit(id, item);
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

        protected override DataAccess<Place, PlaceView> LoadDataAccess()
        {
            return new DataAccess<Place, PlaceView>(Context, Context.Place);
        }

        protected override Func<int, Place> GetItemFunction()
        {
            return i => Context.Place
                        .Include(p => p.TerritoryPlaces).ThenInclude(t => t.Territory).ThenInclude(t => t.TerritoryType)
                        .Include(p => p.TerritoryPlaces).ThenInclude(t => t.Territory).ThenInclude(t => t.Parent)
                        .Include(p => p.TerritoryPlaces).ThenInclude(t => t.Territory).ThenInclude(t => t.Flag)
                        .Include(p => p.TerritoryPlaces).ThenInclude(t => t.Territory).ThenInclude(t => t.Parent).ThenInclude(x => x.Flag)
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<Place>> GetItemsFunction()
        {
            return () => Context.Place
                            .Include(p=> p.TerritoryPlaces);
        }

        protected override Func<Place, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods
    }
}
