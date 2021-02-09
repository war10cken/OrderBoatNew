using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using OrderBoatNew.Domain.Models;
using OrderBoatNew.Domain.Services;
using OrderBoatNew.EntityFramework;
using OrderBoatNew.EntityFramework.Services;
using OrderBoatNew.WPF.Services;
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
            services.AddSingleton<IDataService<Model>, GenericDataService<Model>>();
            services.AddSingleton<IDataService<Wood>, GenericDataService<Wood>>();
            services.AddSingleton<IDataService<Color>, GenericDataService<Color>>();
            services.AddSingleton<IColorService, ColorService>();

            services.AddSingleton<IRootOrderBoarNewViewModelFactory, RootOrderBoatNewViewModelFactory>();
            services.AddSingleton<IOrderBoatNewViewModelFactory<BoatCardViewModel>, BoatCardViewModelFactory>();
            services.AddSingleton<IOrderBoatNewViewModelFactory<BoatViewModel>, BoatViewModelFactory>();
            services.AddSingleton<IOrderBoatNewViewModelFactory<BoatAccessoryViewModel>, BoatsAccessoryViewModelFactory>();

            services.AddScoped<INavigator, Navigator>();
            services.AddScoped<MainViewModel>();

            services.AddScoped(s => new MainWindow(s.GetRequiredService<MainViewModel>()));

            return services.BuildServiceProvider();
        }
    }
}