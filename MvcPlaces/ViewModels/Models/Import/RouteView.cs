using MvcPlaces.ModelsImport;
using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.ViewModels.Models.Import
{
    public class RouteView : ImportableView<Route>
    {
        public int Id => ViewObject.Id;

        public string Name => ViewObject.Name;

        public string Description => ViewObject.Description;

        [Display(Name = "Import Id")]
        public override int? ImportId => ViewObject.ImportId;

        public override string ListName => Name;
    }
}
