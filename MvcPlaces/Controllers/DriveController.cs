using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcPlaces.Code.Data;
using MvcPlaces.Models;
using MvcPlaces.ViewModels.Models.Main;

namespace MvcPlaces.Controllers
{
    public class DriveController : TravelController<Drive, DriveView>
    {
        #region Constructor

        public DriveController(TravelContext context)
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
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] Drive item)
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
        public override async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] Drive item)
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

        protected override DataAccess<Drive, DriveView> LoadDataAccess()
        {
            return new DataAccess<Drive, DriveView>(Context, Context.Drive);
        }

        protected override Func<int, Drive> GetItemFunction()
        {
            return i => Context.Drive
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<Drive>> GetItemsFunction()
        {
            return () => Context.Drive;
        }

        protected override Func<Drive, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods
    }
}