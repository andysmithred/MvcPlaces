using MvcPlaces.ModelsImport;

namespace MvcPlaces.ViewModels.Models.Import
{
    public class PlaceGroupSetView : ImportableView<ModelsImport.PlaceGroupSet>
    {
        public int Id => ViewObject.Id;
        public int PlaceId => ViewObject.PlaceId;
        public int GroupId => ViewObject.GroupId;
        public override int? ImportId => ViewObject.ImportId;

        public PlaceView Place => GetView<PlaceView, Place>(ViewObject.Place);
        public PlaceGroupView Group => GetView<PlaceGroupView, PlaceGroup>(ViewObject.Group);

        public override string ListName => Place.Name + " : " + Group.Name;
    }
}