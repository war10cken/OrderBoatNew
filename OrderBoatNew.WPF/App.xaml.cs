using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderBoatNew.Domain.Models;
using OrderBoatNew.Domain.Services;
using OrderBoatNew.Domain.Services.AuthenticationService;
using OrderBoatNew.EntityFramework;
using OrderBoatNew.EntityFramework.Services;
using OrderBoatNew.WPF.Services;
using OrderBoatNew.WPF.State.Authenticators;
using OrderBoatNew.WPF.State.Navigators;
using OrderBoatNew.WPF.ViewModels;
using OrderBoatNew.WPF.ViewModels.Factories;
using System.Windows;

namespace OrderBoatNew.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IHost _host;

        public App()
        {
            _host = CreateHostBuilder().Build();
        }

        public static IHostBuilder CreateHostBuilder(string[] args = null)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(c =>
                {
                    c.AddJsonFile("appsettings.json");
                    c.AddEnvironmentVariables();
                })
                .ConfigureServices((context, services) =>
                {
                    string connectionString = context.Configuration.GetConnectionString("default");

                    services.AddDbContext<OrderBoatNewDbContext>(o => o.UseSqlServer(connectionString));
                    services.AddSingleton<OrderBoatNewDbContextFactory>(new OrderBoatNewDbContextFactory(connectionString));
                    services.AddSingleton<IAuthenticationService, AuthenticationService>();
                    services.AddSingleton<IUserService, UserService>();
                    services.AddSingleton<IDataService<Model>, GenericDataService<Model>>();
                    services.AddSingleton<IDataService<Wood>, GenericDataService<Wood>>();
                    services.AddSingleton<IDataService<Color>, GenericDataService<Color>>();
                    services.AddSingleton<IColorService, ColorService>();

                    services.AddSingleton<IPasswordHasher, PasswordHasher>();

                    services.AddSingleton<IOrderBoarNewViewModelFactory, OrderBoatNewViewModelFactory>();
                    services.AddSingleton<BoatViewModel>(s => new BoatViewModel(
                        BoatCardViewModel.LoadBoatCardViewModel(s.GetRequiredService<IDataService<Model>>(),
                        s.GetRequiredService<IDataService<Wood>>(),
                        s.GetRequiredService<IColorService>())));

                    services.AddSingleton<CreateViewModel<BoatViewModel>>(s => s.GetRequiredService<BoatViewModel>);

                    services.AddSingleton<CreateViewModel<BoatAccessoryViewModel>>(s =>
                    {
                        return () => new BoatAccessoryViewModel();
                    });

                    services.AddSingleton<ViewModelDelegateRenavigator<LoginViewModel>>();
                    services.AddSingleton<CreateViewModel<RegisterViewModel>>(s =>
                    {
                        return () => new RegisterViewModel(
                            s.GetRequiredService<IAuthenticator>(),
                            s.GetRequiredService<ViewModelDelegateRenavigator<LoginViewModel>>(),
                            s.GetRequiredService<ViewModelDelegateRenavigator<LoginViewModel>>());
                    });

                    services.AddSingleton<ViewModelDelegateRenavigator<BoatViewModel>>();
                    services.AddSingleton<ViewModelDelegateRenavigator<RegisterViewModel>>();
                    services.AddSingleton<CreateViewModel<LoginViewModel>>(s =>
                    {
                        return () => new LoginViewModel(s.GetRequiredService<IAuthenticator>(),
                            s.GetRequiredService<ViewModelDelegateRenavigator<BoatViewModel>>(),
                            s.GetRequiredService<ViewModelDelegateRenavigator<RegisterViewModel>>());
                    });

                    services.AddScoped<INavigator, Navigator>();
                    services.AddScoped<IAuthenticator, Authenticator>();
                    services.AddScoped<MainViewModel>();

                    services.AddScoped(s => new MainWindow(s.GetRequiredService<MainViewModel>()));
                });
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _host.Start();

            Window window = _host.Services.GetRequiredService<MainWindow>();
            window.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();

            base.OnExit(e);
        }
    }
}