using System;
using OrderBoatNew.WPF.State.Navigators;

namespace OrderBoatNew.WPF.ViewModels.Factories
{
    public class OrderBoatNewViewModelFactory : IOrderBoarNewViewModelFactory
    {
        private readonly CreateViewModel<BoatViewModel> _createBoatViewModel;
        private readonly CreateViewModel<BoatAccessoryViewModel> _createBoatAccessoryViewModel;
        private readonly CreateViewModel<LoginViewModel> _createLoginViewModel;

        public OrderBoatNewViewModelFactory(CreateViewModel<BoatViewModel> createBoatViewModel,
                                                CreateViewModel<BoatAccessoryViewModel> createBoatAccessoryViewModel,
                                                CreateViewModel<LoginViewModel> createLoginViewModel)
        {
            _createBoatViewModel = createBoatViewModel;
            _createBoatAccessoryViewModel = createBoatAccessoryViewModel;
            _createLoginViewModel = createLoginViewModel;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Login:
                    return _createLoginViewModel();
                case ViewType.Boats:
                    return _createBoatViewModel();
                case ViewType.BoatsAccessory:
                    return _createBoatAccessoryViewModel();
                default:
                    throw new ArgumentException(nameof(viewType));
            }
        }
    }
}