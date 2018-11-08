using MvcPlaces.ModelsImport;

namespace MvcPlaces.ViewModels.Models.Import
{
    public class CountryView : ImportableView<ModelsImport.Country>
    {
        #region Database Properties

        public int Id => ViewObject.Id;
        public string Name => ViewObject.Name;
        public string FullName => ViewObject.FullName;
        public int ContinentId => ViewObject.ContinentId;
        public int? Population => ViewObject.Population;
        public int? Area => ViewObject.Area;
        public string Isocode => ViewObject.Isocode;
        public double Latitude => ViewObject.Latitude;
        public double Longitude => ViewObject.Longitude;
        public int Zoom => ViewObject.Zoom;

        public override int? ImportId => ViewObject.ImportId;

        #endregion Database Properties

        #region Foreign Properties

        public ContinentView Continent => GetView<ContinentView, Continent>(ViewObject.Continent);

        #endregion Foreign Properties

        #region Other Properties

        public override string ListName => Name + ":" + FullName;

        #endregion Other Properties
    }
}