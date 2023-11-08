using KretaBasicSchoolSystem.Desktop.ViewModels;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.ViewModels.Login;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.Views;
using KretaBasicSchoolSystem.Desktop.Views.ControlPanel;
using KretaBasicSchoolSystem.Desktop.Views.Login;
using KretaBasicSchoolSystem.Desktop.Views.SchoolCitizens;
using Microsoft.Extensions.DependencyInjection;

namespace KretaDesktop.Extensions
{
    public static class ViewViewModelsExtensions
    {
        public static void ConfigureViewViewModels(this IServiceCollection services)
        {
            // MainView
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainView>(s => new MainView()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            // LoginView
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<LoginView>(s => new LoginView()
            {
                DataContext = s.GetRequiredService<LoginViewModel>()
            });

            // ControlPanel
            services.AddSingleton<ControlPanelViewModel>();
            services.AddSingleton<ControlPanelView>(s => new ControlPanelView()
            {
                DataContext = s.GetRequiredService<ControlPanelViewModel>()
            });
            // School Citizens
            // ControlPanel
            services.AddSingleton<SchoolCitizensViewModel>();
            services.AddSingleton<SchoolCitizensView>(s => new SchoolCitizensView()
            {
                DataContext = s.GetRequiredService<SchoolCitizensViewModel>()
            });

        }
    }
}
