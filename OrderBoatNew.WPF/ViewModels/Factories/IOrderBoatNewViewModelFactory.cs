namespace OrderBoatNew.WPF.ViewModels.Factories
{
    public interface IOrderBoatNewViewModelFactory<out T> where T : ViewModelBase
    {
        T CreateViewModel();
    }
}