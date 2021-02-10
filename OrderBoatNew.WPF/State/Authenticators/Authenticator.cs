using System;
using System.Threading.Tasks;
using OrderBoatNew.Domain.Models;
using OrderBoatNew.Domain.Services.AuthenticationService;
using OrderBoatNew.WPF.Models;

namespace OrderBoatNew.WPF.State.Authenticators
{
    public class Authenticator : ObservableObject, IAuthenticator
    {
        private readonly IAuthenticationService _authenticationService;
        
        public Authenticator(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        private User _currentUser;

        public User CurrentUser
        {
            get => _currentUser;
            private set
            {
                _currentUser = value;
                OnPropertyChanged(nameof(CurrentUser));
                OnPropertyChanged(nameof(IsLoggedIn));
            }
        }
        
        public bool IsLoggedIn => CurrentUser != null;

        public async Task<RegistrationResult> Register(string email, string username, string password,
                                                       string confirmPassword)
        {
            return await _authenticationService.Register(email, username, password, confirmPassword);
        }

        public async Task Login(string username, string password)
        {
            CurrentUser = await _authenticationService.Login(username, password);
        }

        public void Logout() => CurrentUser = null;
    }
}