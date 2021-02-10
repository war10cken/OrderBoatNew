using System.Windows.Input;
using OrderBoatNew.WPF.Commands;
using OrderBoatNew.WPF.State.Authenticators;
using OrderBoatNew.WPF.State.Navigators;

namespace OrderBoatNew.WPF.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _username;

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private string _errorMessage;

        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel(IAuthenticator authenticator, IRenavigator renavigator)
        {
            LoginCommand = new LoginCommand(authenticator, this, renavigator);
        }
    }
}