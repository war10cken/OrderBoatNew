using System;
using System.Threading.Tasks;
using Bogus;
using Microsoft.AspNet.Identity;
using OrderBoatNew.Domain.Exeptions;
using OrderBoatNew.Domain.Models;

namespace OrderBoatNew.Domain.Services.AuthenticationService
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserService _userService;
        private readonly IPasswordHasher _passwordHasher;
        
        public AuthenticationService(IUserService userService, IPasswordHasher passwordHasher)
        {
            _userService = userService;
            _passwordHasher = passwordHasher;
        }

        public async Task<RegistrationResult> Register(string email, string username, string password,
                                                       string confirmPassword)
        {
            RegistrationResult result = RegistrationResult.Success;

            if (password != confirmPassword)
                result = RegistrationResult.PasswordDoNotMatch;

            User emailUser = await _userService.GetByEmail(email);

            if (emailUser is not null)
                result = RegistrationResult.EmailAlreadyExist;

            User usernameUser = await _userService.GetByUserName(username);

            if (usernameUser is not null)
                result = RegistrationResult.UsernameAlreadyExist;

            if (result is RegistrationResult.Success)
            {
                string hashedPassword = _passwordHasher.HashPassword(password);
                
                User user = new User
                {
                    Email = email,
                    DatedJoined = DateTime.Now,
                    Password = hashedPassword,
                    Username = username
                };

                await _userService.Create(user);
            }

           
            return result;
        }

        public async Task<User> Login(string username, string password)
        {
            User userStored = await _userService.GetByUserName(username);

            if (userStored is null)
                throw new UserNotFoundException(username);
            
            PasswordVerificationResult passwordResult =
                _passwordHasher.VerifyHashedPassword(userStored.Password, password);

            if (passwordResult is not PasswordVerificationResult.Success)
                throw new InvalidPasswordException(username, password);

            return userStored;
        }
    }
}