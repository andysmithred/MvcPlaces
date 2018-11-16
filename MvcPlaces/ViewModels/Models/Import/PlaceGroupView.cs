namespace MvcPlaces.ViewModels.Models.Import
{
    public class PlaceGroupView : ImportableView<ModelsImport.PlaceGroup>
    {
        public int Id => ViewObject.Id;
        public string Name => ViewObject.Name;
        public string Description => ViewObject.Description;
        public override int? ImportId => ViewObject.ImportId;
        public override string ListName => Name;
    }
}