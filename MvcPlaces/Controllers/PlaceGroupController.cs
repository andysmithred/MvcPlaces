using Microsoft.AspNetCore.Mvc;
using MvcPlaces.Code.Data;
using MvcPlaces.Models;
using MvcPlaces.ViewModels.Models.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.Controllers
{
    public class PlaceGroupController : TravelController<PlaceGroup, PlaceGroupView>
    {
        #region Constructor

        public PlaceGroupController(TravelContext context)
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
            return base.Create();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Icon")] PlaceGroup item)
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
        public override async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Icon")] PlaceGroup item)
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

        protected override DataAccess<PlaceGroup, PlaceGroupView> LoadDataAccess()
        {
            return new DataAccess<PlaceGroup, PlaceGroupView>(Context, Context.PlaceGroup);
        }

        protected override Func<int, PlaceGroup> GetItemFunction()
        {
            return i => Context.PlaceGroup
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<PlaceGroup>> GetItemsFunction()
        {
            return () => Context.PlaceGroup;
        }

        protected override Func<PlaceGroup, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods
    }
}
