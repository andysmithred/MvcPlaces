namespace MvcPlaces.Code.Interfaces
{
    public interface IView<TObject>
    {
        TObject ViewObject { get; set; }
    }
}