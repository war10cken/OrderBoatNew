using OrderBoatNew.Domain.Services.AuthenticationService;
using OrderBoatNew.WPF.State.Authenticators;
using OrderBoatNew.WPF.State.Navigators;
using OrderBoatNew.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBoatNew.WPF.Commands
{
    public class RegisterCommand : AsyncCommandBase
    {
        private readonly RegisterViewModel _registerViewModel;
        private readonly IAuthenticator _authenticator;
        private readonly IRenavigator _renavigator;

        public RegisterCommand(RegisterViewModel registerViewModel, IAuthenticator authenticator, IRenavigator renavigator)
        {
            _registerViewModel = registerViewModel;
            _authenticator = authenticator;
            _renavigator = renavigator;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _registerViewModel.ErrorMessage = string.Empty;

            try
            {
                RegistrationResult registration = await _authenticator.Register(
                  _registerViewModel.Email,
                  _registerViewModel.Username,
                  _registerViewModel.Password,
                  _registerViewModel.ConfirmPassword);

                switch (registration)
                {
                    case RegistrationResult.Success:
                        _renavigator.Renavigate();
                        break;

                    case RegistrationResult.PasswordDoNotMatch:
                        _registerViewModel.ErrorMessage = "Пароль не соответствуют введённому паролю.";
                        break;

                    case RegistrationResult.EmailAlreadyExist:
                        _registerViewModel.ErrorMessage = "Такой email уже существует.";
                        break;

                    case RegistrationResult.UsernameAlreadyExist:
                        _registerViewModel.ErrorMessage = "Пользователь с таким именем уже существует.";
                        break;

                    default:
                        _registerViewModel.ErrorMessage = "Ошибка регистрации";
                        break;
                }
            }
            catch (Exception)
            {
                _registerViewModel.ErrorMessage = "Ошибка регистрации";
            }
        }
    }
}