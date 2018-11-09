using MvcPlaces.Code.Classes;
using MvcPlaces.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MvcPlaces.ViewModels.Models.Main
{
    public class PlaceView : View<Place>
    {
        #region Database Properties

        [Key]
        public int Id => ViewObject.Id;

        [Required]
        public string Name => ViewObject.Name;

        [Display(Name = "Local Name")]
        public string LocalName => ViewObject.LocalName;

        public double? Latitude => ViewObject.Latitude;

        public double? Longitude => ViewObject.Longitude;

        public int? Zoom => ViewObject.Zoom;

        #endregion Database Properties

        #region Foreign Properties

        //public ContinentView Continent => GetView<ContinentView, Continent>(ViewObject.Continent);
        //public TerritoryView Parent => GetView<TerritoryView, Territory>(ViewObject.Parent);
        //public TerritoryTypeView TerritoryType => GetView<TerritoryTypeView, TerritoryType>(ViewObject.TerritoryType);

        public ICollection<TerritoryPlaceView> TerritoryPlaces => GetViewList<TerritoryPlaceView, TerritoryPlace>(ViewObject.TerritoryPlaces);

        #endregion Foreign Properties

        #region Other Properties

        public override string ListName => Name;

        public string DetailsName => string.IsNullOrEmpty(LocalName) ? "--" : LocalName;

        public double LatitudeValue => Latitude.HasValue ? Latitude.Value : 0;
        public string LatitudeDegrees => Latitude.HasValue ? GeoAngle.FromDouble(Latitude.Value).ToString("NS") : "--";
        
        public double LongitudeValue => Longitude.HasValue ? Longitude.Value : 0;
        public string LongitudeDegrees => Longitude.HasValue ? GeoAngle.FromDouble(Longitude.Value).ToString("WE") : "--";

        public int ZoomValue => Zoom.HasValue ? Zoom.Value : 0;
        public string ZoomString => Zoom.HasValue ? Zoom.Value.ToString() : "--";

        public ICollection<TerritoryView> Territories => TerritoryPlaces.Select(x => x.Territory).Distinct(x => x.Id).ToList();

        #endregion Other Properties
    }
}
