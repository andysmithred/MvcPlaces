using MvcPlaces.Code.Classes;
using MvcPlaces.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MvcPlaces.ViewModels.Models.Main
{
    public class PlaceGroupView : View<PlaceGroup>
    {
        #region Database Properties

        [Key]
        public int Id => ViewObject.Id;

        [Required]
        public string Name => ViewObject.Name;

        public string Description => ViewObject.Description;

        [StringLength(50)]
        public string Icon => ViewObject.Icon;

        #endregion Database Properties

        #region Foreign Properties

        public ICollection<PlaceGroupSetView> PlaceGroupSets => GetViewList<PlaceGroupSetView, PlaceGroupSet>(ViewObject.PlaceGroupSets);

        #endregion Foreign Properties

        #region Other Properties

        public override string ListName => Name;

        public ICollection<PlaceView> Places => PlaceGroupSets.Select(x => x.Place).Distinct(x => x.Id).ToList();

        #endregion Other Properties
    }
}