namespace MvcPlaces.ModelsImport
{
    public partial class DriveLeg
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int DriveId { get; set; }
        public int OriginId { get; set; }
        public int DestinationId { get; set; }
        public string Description { get; set; }
        public int? ImportId { get; set; }

        public Place Destination { get; set; }
        public Drive Drive { get; set; }
        public Place Origin { get; set; }
    }
}