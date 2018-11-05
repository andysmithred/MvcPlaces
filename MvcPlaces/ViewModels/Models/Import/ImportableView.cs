using MvcPlaces.Code.Interfaces;

namespace MvcPlaces.ViewModels.Models.Import
{
    public abstract class ImportableView<TObject> : View<TObject>, IImportableView<TObject>
    {
        public abstract int? ImportId { get; }
    }
}