using OrderBoatNew.WPF.ViewModels;
using OrderBoatNew.WPF.ViewModels.Factories;

namespace OrderBoatNew.WPF.State.Navigators
{
    public class ViewModelFactoryRenavigator<TViewModel> : IRenavigator where TViewModel : ViewModelBase
    {
        private readonly INavigator _navigator;
        private readonly IOrderBoatNewViewModelFactory<TViewModel> _viewModelFactory;
        
        public ViewModelFactoryRenavigator(INavigator navigator, IOrderBoatNewViewModelFactory<TViewModel> viewModelFactory)
        {
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
        }

        public void Renavigate()
        {
            _navigator.CurrentViewModel = _viewModelFactory.CreateViewModel();
        }
    }
}