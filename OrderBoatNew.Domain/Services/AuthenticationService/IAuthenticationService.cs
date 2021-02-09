using System.Threading.Tasks;
using OrderBoatNew.Domain.Models;

namespace OrderBoatNew.Domain.Services.AuthenticationService
{
    public interface IAuthenticationService
    {
        Task<bool> Register(string email, string username, string password, string confirmPassword);
        Task<User> Login(string username, string password);
    }
}