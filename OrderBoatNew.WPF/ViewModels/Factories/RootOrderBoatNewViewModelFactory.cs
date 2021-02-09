using System;
using OrderBoatNew.WPF.State.Navigators;

namespace OrderBoatNew.WPF.ViewModels.Factories
{
    public class RootOrderBoatNewViewModelFactory : IRootOrderBoarNewViewModelFactory
    {
        private readonly IOrderBoatNewViewModelFactory<BoatViewModel> _boatViewModelFactory;
        private readonly IOrderBoatNewViewModelFactory<BoatAccessoryViewModel> _boatAccessoryViewModelFactory;
        
        public RootOrderBoatNewViewModelFactory(IOrderBoatNewViewModelFactory<BoatViewModel> boatViewModelFactory,
                                                    IOrderBoatNewViewModelFactory<BoatAccessoryViewModel> boatAccessoryViewModelFactory)
        {
            _boatViewModelFactory = boatViewModelFactory;
            _boatAccessoryViewModelFactory = boatAccessoryViewModelFactory;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
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