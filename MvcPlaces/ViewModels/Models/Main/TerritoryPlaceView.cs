using MvcPlaces.Models;
using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.ViewModels.Models.Main
{
    public class TerritoryPlaceView : View<TerritoryPlace>
    {
        #region Database Properties

        public int Id => ViewObject.Id;

        [Display(Name = "Territory")]
        public int TerritoryId => ViewObject.TerritoryId;

        [Display(Name = "Place")]
        public int PlaceId => ViewObject.PlaceId;

        #endregion Database Properties

        #region Foreign Properties

        public TerritoryView Territory => GetView<TerritoryView, Territory>(ViewObject.Territory);
        public PlaceView Place => GetView<PlaceView, Place>(ViewObject.Place);

        #endregion Foreign Properties

        #region Other Properties

        public override string ListName => Place.Name + " : " + Territory.Name;

        #endregion Other Properties
    }
}