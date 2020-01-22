using MvcPlaces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.ViewModels.Models.Main
{
    public class RouteLegView : View<RouteLeg>
    {
        #region Database Properties

        [Key]
        public int Id => ViewObject.Id;

        [Required]
        public int Number => ViewObject.Number;

        [Required]
        public int RouteId => ViewObject.RouteId;

        [Required]
        public int OriginId => ViewObject.OriginId;

        [Required]
        public int DestinationId => ViewObject.DestinationId;

        public string Description => ViewObject.Description;

        #endregion Database Properties

        #region Foreign Properties

        public RouteView Route => GetView<RouteView, Route>(ViewObject.Route);
        public PlaceView Origin => GetView<PlaceView, Place>(ViewObject.Origin);
        public PlaceView Destination => GetView<PlaceView, Place>(ViewObject.Destination);

        #endregion Foreign Properties

        #region Other Properties

        public override string ListName => Number + "|" + Route.Name + "|" + Origin.Name + "|" + Destination.Name;

        #endregion Other Properties

        #region Methods



        #endregion Methods
    }
}
