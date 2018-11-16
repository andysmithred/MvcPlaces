namespace MvcPlaces.ModelsImport
{
    public partial class PlaceGroupSet
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int PlaceId { get; set; }
        public int? ImportId { get; set; }

        public PlaceGroup Group { get; set; }
        public Place Place { get; set; }
    }
}