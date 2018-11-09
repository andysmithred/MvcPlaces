using MvcPlaces.ModelsImport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.ViewModels.Models.Import
{
    public class PlaceView : ImportableView<ModelsImport.Place>
    {
        public int Id => ViewObject.Id;
        public string Name => ViewObject.Name;
        public int RegionId => ViewObject.RegionId;
        public double? Latitude => ViewObject.Latitude;
        public double? Longitude => ViewObject.Longitude;
        public override int? ImportId => ViewObject.ImportId;

        public RegionView Region => GetView<RegionView, Region>(ViewObject.Region);

        //public ICollection<AirfieldPlace> AirfieldPlace { get; set; }
        //public ICollection<DriveLeg> DriveLegDestination { get; set; }
        //public ICollection<DriveLeg> DriveLegOrigin { get; set; }
        //public ICollection<PlaceGroupSet> PlaceGroupSet { get; set; }

        public override string ListName => Name + " : " + Region.Name;
    }
}
