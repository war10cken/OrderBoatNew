namespace OrderBoatNew.WPF.ViewModels.Factories
{
    public class BoatViewModelFactory : IOrderBoatNewViewModelFactory<BoatViewModel>
    {
        private readonly IOrderBoatNewViewModelFactory<BoatCardViewModel> _boatCardViewModelFactory;
        
        public BoatViewModelFactory(IOrderBoatNewViewModelFactory<BoatCardViewModel> boatCardViewModelFactory)
        {
            _boatCardViewModelFactory = boatCardViewModelFactory;
        }

        public BoatViewModel CreateViewModel()
        {
            return new BoatViewModel(_boatCardViewModelFactory.CreateViewModel());
        }
    }
}