using MvcPlaces.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.ViewModels.Models.Main
{
    public class ContinentView : View<Continent>
    {
        #region Database Properties

        public int Id => ViewObject.Id;
        public string Name => ViewObject.Name;
        public string Code => ViewObject.Code;

        [Display(Name = "Parent")]
        public int? ParentId => ViewObject.ParentId;

        #endregion Database Properties

        #region Foreign Properties

        public ContinentView Parent => GetView<ContinentView, Continent>(ViewObject.Parent);
        public ICollection<ContinentView> Children => GetViewList<ContinentView, Continent>(ViewObject.Children);
        public ICollection<TerritoryView> Territories => GetViewList<TerritoryView, Territory>(ViewObject.Territories);

        #endregion Foreign Properties

        #region Other Properties

        public override string ListName => Name;

        public int TerritoryCount => Territories.Count;

        #endregion Other Properties
    }
}