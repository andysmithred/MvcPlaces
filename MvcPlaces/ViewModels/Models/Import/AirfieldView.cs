using MvcPlaces.ModelsImport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.ViewModels.Models.Import
{
    public class AirfieldView : ImportableView<ModelsImport.Airfield>
    {
        public int Id => ViewObject.Id;
        public string Name => ViewObject.Name;
        public int RegionId => ViewObject.RegionId;
        public int? Elevation => ViewObject.Elevation;
        public string IataCode => ViewObject.IataCode;
        public string Type => ViewObject.Type;
        public double? Latitude => ViewObject.Latitude;
        public double? Longitude => ViewObject.Longitude;
        public int? BaseId => ViewObject.BaseId;
        public string IcaoCode => ViewObject.IcaoCode;
        public int Prominence => ViewObject.Prominence;
        public override int? ImportId => ViewObject.ImportId;

        //public Base Base { get; set; }

        public RegionView Region => GetView<RegionView, Region>(ViewObject.Region);

        //public ICollection<AirfieldCity> AirfieldCity { get; set; }
        //public ICollection<AirfieldGroupSet> AirfieldGroupSet { get; set; }
        //public ICollection<AirfieldPlace> AirfieldPlace { get; set; }
        //public ICollection<Leg> LegDestinationAirfield { get; set; }
        //public ICollection<Leg> LegOriginAirfield { get; set; }
        //public ICollection<Runway> Runway { get; set; }

        public override string ListName => throw new NotImplementedException();
    }
}
