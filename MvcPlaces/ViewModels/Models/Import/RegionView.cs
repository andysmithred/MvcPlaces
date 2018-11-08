using MvcPlaces.ModelsImport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.ViewModels.Models.Import
{
    public class RegionView : ImportableView<ModelsImport.Region>
    {
        #region Database Properties

        public int Id => ViewObject.Id;
        public string Name => ViewObject.Name;
        public int CountryId => ViewObject.CountryId;
        public double? Area => ViewObject.Area;
        public int? Population => ViewObject.Population;
        public string Isocode => ViewObject.Isocode;
        public string Type => ViewObject.Type;
        public override int? ImportId => ViewObject.ImportId;

        #endregion Database Properties

        #region Foreign Properties

        public CountryView Country => GetView<CountryView, Country>(ViewObject.Country);
        //public ICollection<CountryView> Countries => GetViewList<CountryView, Country>(ViewObject.Place);

        #endregion Foreign Properties

        #region Other Properties

        public override string ListName => Name + ":" + Isocode;

        #endregion Other Properties
    }
}
