using System;
using System.Windows;
using Microsoft.AspNet.Identity;
using Microsoft.Extensions.DependencyInjection;
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

namespace OrderBoatNew.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IServiceProvider serviceProvider = CreateServiceProvider();

            Window window = serviceProvider.GetRequiredService<MainWindow>();
            window.Show();

            base.OnStartup(e);
        }

        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<OrderBoatNewDbContextFactory>();
            services.AddSingleton<IAuthenticationService, AuthenticationService>();
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IDataService<Model>, GenericDataService<Model>>();
            services.AddSingleton<IDataService<Wood>, GenericDataService<Wood>>();
            services.AddSingleton<IDataService<Color>, GenericDataService<Color>>();
            services.AddSingleton<IColorService, ColorService>();

            services.AddSingleton<IPasswordHasher, PasswordHasher>();

            services.AddSingleton<IRootOrderBoarNewViewModelFactory, RootOrderBoatNewViewModelFactory>();
            services.AddSingleton<IOrderBoatNewViewModelFactory<BoatCardViewModel>, BoatCardViewModelFactory>();
            services.AddSingleton<IOrderBoatNewViewModelFactory<BoatViewModel>, BoatViewModelFactory>();
            services.AddSingleton<IOrderBoatNewViewModelFactory<BoatAccessoryViewModel>, BoatsAccessoryViewModelFactory>();
            
            services.AddSingleton<IOrderBoatNewViewModelFactory<LoginViewModel>>(s =>
                                                                                     new
                                                                                         LoginViewModelFactory(s.GetRequiredService<IAuthenticator>(),
                                                                                                               new
                                                                                                                   ViewModelFactoryRenavigator
                                                                                                                   <BoatViewModel
                                                                                                                   >(s.GetRequiredService<INavigator>(),
                                                                                                                     s.GetRequiredService
                                                                                                                     <IOrderBoatNewViewModelFactory
                                                                                                                         <BoatViewModel
                                                                                                                         >>())));

            services.AddScoped<INavigator, Navigator>();
            services.AddScoped<IAuthenticator, Authenticator>();
            services.AddScoped<MainViewModel>();

            services.AddScoped(s => new MainWindow(s.GetRequiredService<MainViewModel>()));

            return services.BuildServiceProvider();
        }
    }
}