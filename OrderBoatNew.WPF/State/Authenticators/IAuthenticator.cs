using System.Threading.Tasks;
using OrderBoatNew.Domain.Models;
using OrderBoatNew.Domain.Services.AuthenticationService;

namespace OrderBoatNew.WPF.State.Authenticators
{
    public interface IAuthenticator
    {
        User CurrentUser { get; }
        bool IsLoggedIn { get; }

        Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword);
        Task Login(string username, string password);
        void Logout();
    }
}