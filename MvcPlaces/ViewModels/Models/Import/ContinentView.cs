﻿namespace MvcPlaces.ViewModels.Models.Import
{
    public class ContinentView : ImportableView<ModelsImport.Continent>
    {
        #region Database Properties

        public int Id => ViewObject.Id;
        public string Name => ViewObject.Name;
        public string Code => ViewObject.Code;
        public override int? ImportId => ViewObject.ImportId;

        #endregion Database Properties

        #region Foreign Properties

        //public ICollection<ContinentView> Countries => GetViewList<ContinentView, Continent>(ViewObject.Country);

        #endregion Foreign Properties

        #region Other Properties

        public override string ListName => Name;

        #endregion Other Properties
    }
}