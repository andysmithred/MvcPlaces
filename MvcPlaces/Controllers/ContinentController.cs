using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcPlaces.Code.Data;
using MvcPlaces.Models;
using MvcPlaces.ViewModels.Models.Main;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.Controllers
{
    public class ContinentController : TravelController<Continent, ContinentView>
    {
        #region Constructor

        public ContinentController(TravelContext context)
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

        public async Task<IActionResult> SubcontinentsList(int? id)
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
            ViewBag.ContinentList = new SelectList(DataAccess.GetViews(), "Id", "ListName");
            return base.Create();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Code,ParentId")] Continent item)
        {
            if (ModelState.IsValid)
            {
                await AddAsync(item);
                return RedirectToAction("Details", new { id = item.Id });
            }
            ViewBag.ContinentList = new SelectList(DataAccess.GetViews(), "Id", "ListName");
            return View(item);
        }

        #endregion Create

        #region Edit

        public override async Task<IActionResult> Edit(int? id)
        {
            IActionResult result = await base.Edit(id);
            ViewBag.ContinentList = new SelectList(DataAccess.GetViews(), "Id", "ListName", Item.ParentId);
            return result;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public override async Task<IActionResult> Edit(int id, [Bind("Id,Name,Code,ParentId")] Continent item)
        {
            IActionResult result = await base.Edit(id, item);
            ViewBag.ContinentList = new SelectList(DataAccess.GetViews(), "Id", "ListName", item.ParentId);
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

        protected override DataAccess<Continent, ContinentView> LoadDataAccess()
        {
            return new DataAccess<Continent, ContinentView>(Context, Context.Continent);
        }

        protected override Func<int, Continent> GetItemFunction()
        {
            return i => Context.Continent
                        .Include(x => x.Territories).ThenInclude(t => t.TerritoryType)
                        .Include(x => x.Territories).ThenInclude(t => t.Parent)
                        .Include(x => x.Territories).ThenInclude(t => t.Children)
                        .Include(x => x.Parent)
                        .Include(x => x.Children).ThenInclude(c => c.Territories)
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<Continent>> GetItemsFunction()
        {
            return () => Context.Continent
                        .Include(x => x.Territories).ThenInclude(t => t.TerritoryType)
                        .Include(x => x.Territories).ThenInclude(t => t.Parent)
                        .Include(x => x.Territories).ThenInclude(t => t.Children)
                        .Include(x => x.Parent)
                        .Include(x => x.Children).ThenInclude(c => c.Territories);
        }

        protected override Func<Continent, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods
    }
}
