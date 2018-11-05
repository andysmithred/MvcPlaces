using Microsoft.AspNetCore.Mvc;
using MvcPlaces.Code.Data;
using MvcPlaces.Code.Interfaces;
using MvcPlaces.Models;
using MvcPlaces.ModelsImport;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.Controllers
{
    public abstract class ImportController<TImportFrom, TViewImportFrom, TImportTo, TViewImportTo> :
        BaseController<TImportFrom, TViewImportFrom>
        where TImportFrom : class
        where TViewImportFrom : IImportableView<TImportFrom>, new()
        where TImportTo : class
        where TViewImportTo : IView<TImportTo>, new()
    {
        #region Private Declarations

        private TravelContext importToContext = null;
        private MyDataContext importFromContext = null;

        private DataAccess<TImportTo, TViewImportTo> importToDataAccess = null;

        #endregion Private Declarations

        #region Properties

        public TravelContext ImportToContext
        {
            get => importToContext ?? (importToContext = new TravelContext());
            set => importToContext = value;
        }

        public MyDataContext ImportFromContext
        {
            get => importFromContext ?? (importFromContext = new MyDataContext());
            set => importFromContext = value;
        }

        public DataAccess<TImportTo, TViewImportTo> ImportToDataAccess
        {
            get => importToDataAccess ?? (importToDataAccess = LoadImportToDataAccess());
            set => importToDataAccess = value;
        }

        #endregion Properties

        #region Methods

        #region List

        public async virtual Task<IActionResult> ListImported()
        {
            var items = await DataAccess.GetViewsAsync();
            return View(items.Where(x => x.ImportId.HasValue).ToList());
        }

        public async virtual Task<IActionResult> ListNotImported()
        {
            var items = await DataAccess.GetViewsAsync();
            return View(items.Where(x => x.ImportId == null).ToList());
        }

        #endregion List

        #region Import

        public async virtual Task<IActionResult> Import(int? id)
        {
            return await base.Details(id);
        }

        public async virtual Task<IActionResult> ImportConfirmed(int id)
        {
            Item = await DataAccess.GetItemAsync(id, GetItemFunc());

            if (Item == null)
            {
                return NotFound();
            }
            else
            {
                if (ImportItem(Item))
                {
                    return RedirectToAction("ListImported");
                }
                else
                {
                    return RedirectToAction("CannotImport", new { id });
                }
            }
        }

        public async virtual Task<IActionResult> QuickImport(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Item = await DataAccess.GetItemAsync(id.Value, GetItemFunc());

            if (Item == null)
            {
                return NotFound();
            }
            else
            {
                if (ImportItem(Item))
                {
                    return RedirectToAction("ListNotImported");
                }
                else
                {
                    return RedirectToAction("CannotImport", new { id = id.Value });
                }
            }
        }

        #endregion Import

        #region CannotImport

        public async virtual Task<IActionResult> CannotImport(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Item = await DataAccess.GetItemAsync(id.Value, GetItemFunc());
            if (Item == null)
            {
                return NotFound();
            }
            return View(Item);
        }

        public virtual ActionResult CannotImportConfirmed(int id)
        {
            return RedirectToAction("List");
        }

        #endregion CannotImport

        #endregion Methods

        #region Abstract Methods

        protected abstract DataAccess<TImportTo, TViewImportTo> LoadImportToDataAccess();

        protected abstract bool ImportItem(TImportFrom item);

        protected override abstract Func<int, TImportFrom> GetItemFunc();

        #endregion Abstract Methods
    }
}
