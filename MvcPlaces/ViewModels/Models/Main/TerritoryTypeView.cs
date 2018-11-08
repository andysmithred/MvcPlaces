using MvcPlaces.Models;
using System.Collections.Generic;

namespace MvcPlaces.ViewModels.Models.Main
{
    public class TerritoryTypeView : View<TerritoryType>
    {
        #region Database Properties

        public int Id => ViewObject.Id;
        public string Type => ViewObject.Type;

        #endregion Database Properties

        #region Foreign Properties

        public ICollection<TerritoryView> Territories => GetViewList<TerritoryView, Territory>(ViewObject.Territories);

        #endregion Foreign Properties

        #region Other Properties

        public override string ListName => Type;

        public int TerritoryCount => Territories.Count;

        #endregion Other Properties
    }
}