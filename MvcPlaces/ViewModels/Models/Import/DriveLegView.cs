using MvcPlaces.ModelsImport;
using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.ViewModels.Models.Import
{
    public class DriveLegView : ImportableView<DriveLeg>
    {
        public int Id => ViewObject.Id;

        public int Number => ViewObject.Number;

        public int DriveId => ViewObject.DriveId;
        public Drive Drive => ViewObject.Drive;

        public int OriginId => ViewObject.OriginId;
        public Place Origin => ViewObject.Origin;

        public int DestinationId => ViewObject.DestinationId;
        public Place Destination => ViewObject.Destination;

        public string Description => ViewObject.Description;

        [Display(Name = "Import Id")]
        public override int? ImportId => ViewObject.ImportId;

        public override string ListName => Number + "|" + Drive.Name + "|" + Origin.Name + "|" + Destination.Name;
    }
}