﻿using MvcPlaces.Code.Classes;
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
        [Required]
        public bool Complete => ViewObject.Complete;

        #endregion Database Properties

        #region Foreign Properties

        public ICollection<TerritoryPlaceView> TerritoryPlaces => GetViewList<TerritoryPlaceView, TerritoryPlace>(ViewObject.TerritoryPlaces);
        public ICollection<PlaceGroupSetView> PlaceGroupSets => GetViewList<PlaceGroupSetView, PlaceGroupSet>(ViewObject.PlaceGroupSets);
        public ICollection<DriveLegView> DriveOriginLegs => GetViewList<DriveLegView, DriveLeg>(ViewObject.DriveOriginLegs);
        public ICollection<DriveLegView> DriveDestinationLegs => GetViewList<DriveLegView, DriveLeg>(ViewObject.DriveDestinationLegs);
        public ICollection<RouteLegView> RouteOriginLegs => GetViewList<RouteLegView, RouteLeg>(ViewObject.RouteOriginLegs);
        public ICollection<RouteLegView> RouteDestinationLegs => GetViewList<RouteLegView, RouteLeg>(ViewObject.RouteDestinationLegs);

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
        public ICollection<PlaceGroupView> Groups => PlaceGroupSets.Select(x => x.Group).Distinct(x => x.Id).ToList();

        //public string FlagImage
        //{
        //    get
        //    {
        //        if(Territories.Count > 0)
        //        {
        //            return Territories.FirstOrDefault().FlagImage;
        //        }
        //        else
        //        {
        //            return "/images/flags/BLANK.png";
        //        }
        //    }
        //}


        #endregion Other Properties
    }
}
