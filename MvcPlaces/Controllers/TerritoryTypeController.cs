﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcPlaces.Code.Data;
using MvcPlaces.Models;
using MvcPlaces.ViewModels.Models.Main;

namespace MvcPlaces.Controllers
{
    public class TerritoryTypeController : TravelController<TerritoryType, TerritoryTypeView>
    {
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
        public async Task<IActionResult> Create([Bind("Id,Type")] TerritoryType item)
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
        public override async Task<IActionResult> Edit(int id, [Bind("Id,Type")] TerritoryType item)
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

        #region Constructor

        public TerritoryTypeController(TravelContext context)
            : base(context) { }

        #endregion Constructor

        #region Override Abstract Methods

        protected override DataAccess<TerritoryType, TerritoryTypeView> LoadDataAccess()
        {
            return new DataAccess<TerritoryType, TerritoryTypeView>(Context, Context.TerritoryType);
        }

        protected override Func<int, TerritoryType> GetItemFunction()
        {
            return i => Context.TerritoryType
                        .Include(x => x.Territories).ThenInclude(t => t.Children)
                        .Include(x => x.Territories).ThenInclude(t => t.Flag)
                        .Include(x => x.Territories).ThenInclude(t => t.Parent).ThenInclude(parent => parent.Flag)
                        .Include(x => x.Territories).ThenInclude(t => t.Parent).ThenInclude(parent => parent.Parent).ThenInclude(parent => parent.Flag)
                        .FirstOrDefault(x => x.Id == i);
        }

        protected override Func<IQueryable<TerritoryType>> GetItemsFunction()
        {
            return () => Context.TerritoryType
                        .Include(x => x.Territories).ThenInclude(t => t.Children)
                        .Include(x => x.Territories).ThenInclude(t => t.Parent);
        }

        protected override Func<TerritoryType, bool> GetExistsFunc(int id)
        {
            return i => i.Id == id;
        }

        #endregion Override Abstract Methods
    }
}