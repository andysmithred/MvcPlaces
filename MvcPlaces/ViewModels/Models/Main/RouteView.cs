using MvcPlaces.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.ViewModels.Models.Main
{
    public class RouteView : View<Route>
    {
        #region Database Properties

        [Key]
        public int Id => ViewObject.Id;

        [Required]
        public string Name => ViewObject.Name;

        public string Description => ViewObject.Description;

        #endregion Database Properties

        #region Foreign Properties

        public ICollection<RouteLegView> RouteLegs => GetViewList<RouteLegView, RouteLeg>(ViewObject.RouteLegs);

        #endregion Foreign Properties

        #region Other Properties

        public override string ListName => Name;

        #endregion Other Properties
    }
}
