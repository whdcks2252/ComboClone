using ComboClone.ViewModel;
using ComboClone.ViewModel.SA;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace ComboClone
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public new static App Current => (App)Application.Current;
        public IServiceProvider Services { get; }

        public App()
        {
            Services = ConfigureService();
            var mainView = Services.GetRequiredService<MainWindow>();
            mainView.Show();

        }

        private IServiceProvider ConfigureService()
        {
            var services = new ServiceCollection();
           

            //ViewModels
            services.AddSingleton<CategoryViewModel>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<LTE_5G_ViewModel>();
            services.AddSingleton<SAViewModel>();
            services.AddSingleton<VSWRViewModel>();
            services.AddSingleton<DTFViewModel>();
            services.AddSingleton<CableLossViewModel>();
            services.AddSingleton<CalculatorViewModel>();

            services.AddSingleton<SubMenuViewModel>();
            services.AddSingleton<MainMenuViewModel>();

            //Views
            services.AddSingleton(s => new MainWindow()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            return services.BuildServiceProvider();

        }
    }
}
