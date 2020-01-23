using MvcPlaces.ModelsImport;
using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.ViewModels.Models.Import
{
    public class LegView : ImportableView<Leg>
    {
        public int Id => ViewObject.Id;

        public int Number => ViewObject.Number;

        public int DriveId => ViewObject.RouteId;
        public Route Route => ViewObject.Route;

        public int OriginId => ViewObject.OriginAirfieldId;
        public Airfield OriginAirfield => ViewObject.OriginAirfield;

        public int DestinationAirfieldId => ViewObject.DestinationAirfieldId;
        public Airfield DestinationAirfield => ViewObject.DestinationAirfield;

        public string Description => ViewObject.Description;

        [Display(Name = "Import Id")]
        public override int? ImportId => ViewObject.ImportId;

        public override string ListName => Number + "|" + Route.Name + "|" + OriginAirfield.Name + "|" + DestinationAirfield.Name;
    }
}
