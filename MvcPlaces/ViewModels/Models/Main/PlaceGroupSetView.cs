using MvcPlaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.ViewModels.Models.Main
{
    public class PlaceGroupSetView : View<PlaceGroupSet>
    {
        public int Id => ViewObject.Id;
        public int PlaceId => ViewObject.PlaceId;
        public int GroupId => ViewObject.GroupId;
        
        public PlaceView Place => GetView<PlaceView, Place>(ViewObject.Place);
        public PlaceGroupView Group => GetView<PlaceGroupView, PlaceGroup>(ViewObject.Group);

        public override string ListName => Place.Name + " : " + Group.Name;
    }
}
