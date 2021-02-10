using System;
using OrderBoatNew.WPF.State.Navigators;

namespace OrderBoatNew.WPF.ViewModels.Factories
{
    public class RootOrderBoatNewViewModelFactory : IRootOrderBoarNewViewModelFactory
    {
        private readonly IOrderBoatNewViewModelFactory<BoatViewModel> _boatViewModelFactory;
        private readonly IOrderBoatNewViewModelFactory<BoatAccessoryViewModel> _boatAccessoryViewModelFactory;
        private readonly IOrderBoatNewViewModelFactory<LoginViewModel> _loginViewModelFactory;
        
        public RootOrderBoatNewViewModelFactory(IOrderBoatNewViewModelFactory<BoatViewModel> boatViewModelFactory,
                                                IOrderBoatNewViewModelFactory<BoatAccessoryViewModel> boatAccessoryViewModelFactory,
                                                IOrderBoatNewViewModelFactory<LoginViewModel> loginViewModelFactory)
        {
            _boatViewModelFactory = boatViewModelFactory;
            _boatAccessoryViewModelFactory = boatAccessoryViewModelFactory;
            _loginViewModelFactory = loginViewModelFactory;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Login:
                    return _loginViewModelFactory.CreateViewModel();
                case ViewType.Boats:
                    return _boatViewModelFactory.CreateViewModel();
                case ViewType.BoatsAccessory:
                    return _boatAccessoryViewModelFactory.CreateViewModel();
                default:
                    throw new ArgumentOutOfRangeException(nameof(viewType), viewType, null);
            }
        }
    }
}