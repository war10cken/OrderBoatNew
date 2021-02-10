using OrderBoatNew.WPF.State.Authenticators;
using OrderBoatNew.WPF.State.Navigators;

namespace OrderBoatNew.WPF.ViewModels.Factories
{
    public class LoginViewModelFactory : IOrderBoatNewViewModelFactory<LoginViewModel>
    {
        private readonly IAuthenticator _authenticator;
        private readonly IRenavigator _renavigator;

        public LoginViewModelFactory(IAuthenticator authenticator, IRenavigator renavigator)
        {
            _authenticator = authenticator;
            _renavigator = renavigator;
        }

        public LoginViewModel CreateViewModel()
        {
            return new LoginViewModel(_authenticator, _renavigator);
        }
    }
}