using OrderBoatNew.WPF.State.Navigators;

namespace OrderBoatNew.WPF.ViewModels.Factories
{
    public interface IOrderBoarNewViewModelFactory
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}