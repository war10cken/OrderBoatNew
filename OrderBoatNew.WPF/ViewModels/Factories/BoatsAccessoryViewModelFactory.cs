namespace OrderBoatNew.WPF.ViewModels.Factories
{
    public class BoatsAccessoryViewModelFactory : IOrderBoatNewViewModelFactory<BoatAccessoryViewModel>
    {
        public BoatAccessoryViewModel CreateViewModel()
        {
            return new BoatAccessoryViewModel();
        }
    }
}