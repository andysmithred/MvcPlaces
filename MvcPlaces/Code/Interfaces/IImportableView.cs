namespace MvcPlaces.Code.Interfaces
{
    public interface IImportableView<TObject> : IView<TObject>
    {
        int? ImportId { get; }
    }
}