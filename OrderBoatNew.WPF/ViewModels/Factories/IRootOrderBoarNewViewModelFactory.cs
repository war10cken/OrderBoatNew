using OrderBoatNew.WPF.State.Navigators;

namespace OrderBoatNew.WPF.ViewModels.Factories
{
    public interface IRootOrderBoarNewViewModelFactory
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}