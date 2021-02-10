using System.Windows.Input;
using OrderBoatNew.WPF.Commands;
using OrderBoatNew.WPF.State.Authenticators;
using OrderBoatNew.WPF.State.Navigators;
using OrderBoatNew.WPF.ViewModels.Factories;

namespace OrderBoatNew.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IRootOrderBoarNewViewModelFactory _viewModelFactory;
        
        public INavigator Navigator { get; set; }
        public IAuthenticator Authenticator { get; }
        
        public ICommand UpdateCurrentViewModelCommand { get; }


        public MainViewModel(INavigator navigator, IAuthenticator authenticator,
                             IRootOrderBoarNewViewModelFactory viewModelFactory)
        {
            Navigator = navigator;
            Authenticator = authenticator;
            _viewModelFactory = viewModelFactory;

            UpdateCurrentViewModelCommand = new UpdateViewModelCommand(navigator, viewModelFactory);
            
            UpdateCurrentViewModelCommand.Execute(ViewType.Login);
        }

    }
}