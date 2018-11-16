using MvcPlaces.Models;
using MvcPlaces.Code.Classes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System;

namespace MvcPlaces.ViewModels.Models.Main
{
    public class TerritoryView : View<Territory>
    {
        #region Database Properties

        public int Id => ViewObject.Id;

        public string Name => ViewObject.Name;

        [Display(Name = "Full Name")]
        public string FullName => ViewObject.FullName;

        [Display(Name = "Local Name")]
        public string NativeName => ViewObject.NativeName;

        [Display(Name = "Continent")]
        public int? ContinentId => ViewObject.ContinentId;

        [Display(Name = "Parent")]
        public int? ParentId => ViewObject.ParentId;

        [Display(Name = "Flag")]
        public int? FlagId => ViewObject.FlagId;

        public int? Population => ViewObject.Population;

        public decimal? Area => ViewObject.Area;

        [Display(Name = "ISO")]
        public string Isocode => ViewObject.Isocode;

        public double? Latitude => ViewObject.Latitude;

        public double? Longitude => ViewObject.Longitude;

        public int? Zoom => ViewObject.Zoom;

        [Display(Name = "Type")]
        public int? TerritoryTypeId => ViewObject.TerritoryTypeId;

        [Display(Name = "Geochart")]
        public string GeoChartLevel => ViewObject.GeoChartLevel;

        #endregion Database Properties

        #region Foreign Properties

        public ContinentView Continent => ContinentId.HasValue ? GetView<ContinentView, Continent>(ViewObject.Continent) : Parent.Continent;
        public TerritoryView Parent => GetView<TerritoryView, Territory>(ViewObject.Parent);
        public TerritoryTypeView TerritoryType => GetView<TerritoryTypeView, TerritoryType>(ViewObject.TerritoryType);
        public FlagView Flag => GetView<FlagView, Flag>(ViewObject.Flag);
        public ICollection<TerritoryView> Children => GetViewList<TerritoryView, Territory>(ViewObject.Children);
        public ICollection<TerritoryPlaceView> TerritoryPlaces => GetViewList<TerritoryPlaceView, TerritoryPlace>(ViewObject.TerritoryPlaces);

        #endregion Foreign Properties

        #region Other Properties

        public override string ListName => Name + " : " + Isocode;

        public string DetailsName => string.IsNullOrEmpty(NativeName) ? FullName : NativeName + " | " + FullName;

        public string ParentName => ParentId.HasValue ? Parent.Name : "--";

        public ICollection<PlaceView> Places => TerritoryPlaces.Select(x => x.Place).Distinct(x => x.Id).ToList();

        public string CountryIso
        {
            get
            {
                if(ParentId.HasValue && !String.IsNullOrEmpty(GeoChartLevel))
                {
                    if((Code.Enums.GeoChartLevel)Enum.Parse(typeof(Code.Enums.GeoChartLevel), GeoChartLevel) == Code.Enums.GeoChartLevel.countries)
                    {
                        return Isocode;
                    }
                    else
                    {
                        return Parent.Isocode;
                    }
                }
                else
                {
                    return Isocode;
                }
            }
        }

        public string FlagImage
        {
            get
            {
                if(FlagId.HasValue)
                {
                    return Flag.ImageSource;
                }
                else
                {
                    if(ParentId.HasValue)
                    {
                        return Parent.FlagImage;
                    }
                    else
                    {
                        return "/images/flags/BLANK.png";
                    }
                }
            }
        }

        #endregion Other Properties
    }
}