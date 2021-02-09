using OrderBoatNew.WPF.State.Navigators;

namespace OrderBoatNew.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public INavigator Navigator { get; set; }

        public MainViewModel(INavigator navigator)
        {
            Navigator = navigator;
            
            Navigator.UpdateCurrentViewModelCommand.Execute(ViewType.Boats);
        }

    }
}