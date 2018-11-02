using MvcPlaces.Code.Interfaces;
using MvcPlaces.Models;
using System;

namespace MvcPlaces.Controllers
{
    public abstract class TravelController<T, TView> : BaseController<T, TView>
        where T : class
        where TView : IView<T>, new()
    {
        #region Private Declarations

        private TravelContext context = null;

        #endregion Private Declarations

        #region Properties

        public TravelContext Context
        {
            get => context ?? throw new NullReferenceException("The Travel Context object has not been set.");
            set => context = value;
        }

        #endregion Properties

        #region Constructor

        public TravelController(TravelContext context)
        {
            Context = context;
        }

        #endregion Constructor
    }
}