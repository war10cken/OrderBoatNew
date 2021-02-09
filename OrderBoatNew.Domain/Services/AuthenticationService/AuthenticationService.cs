using System.Threading.Tasks;
using OrderBoatNew.Domain.Models;

namespace OrderBoatNew.Domain.Services.AuthenticationService
{
    public class AuthenticationService : IAuthenticationService
    {
        public async Task<bool> Register(string email, string username, string password, string confirmPassword)
        {
            bool success = false;
            
            if (password == confirmPassword)
            {
                User user = new User()
                {
                    Email    = email,
                    Username = username,
                    Password = password,
                };    
            }

            return success;
        }

        public async Task<User> Login(string username, string password)
        {
            return null;
        }
    }
}