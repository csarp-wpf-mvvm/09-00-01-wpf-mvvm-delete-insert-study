using KretaBasicSchoolSystem.Desktop.ViewModels;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.ViewModels.Login;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolGrades;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects;
using KretaBasicSchoolSystem.Desktop.Views;
using KretaBasicSchoolSystem.Desktop.Views.ControlPanel;
using KretaBasicSchoolSystem.Desktop.Views.Login;
using KretaBasicSchoolSystem.Desktop.Views.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.Views.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.Views.SchoolGrades;
using KretaBasicSchoolSystem.Desktop.Views.SchoolSubjects;
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
            services.AddSingleton<SchoolCitizensViewModel>();
            services.AddSingleton<SchoolCitizensView>(s => new SchoolCitizensView()
            {
                DataContext = s.GetRequiredService<SchoolCitizensViewModel>()
            });

            services.AddSingleton<StudentViewModel>();
            services.AddSingleton<StudentView>(s => new StudentView()
            {
                DataContext = s.GetRequiredService<StudentViewModel>()
            });

            services.AddSingleton<TeacherViewModel>();
            services.AddSingleton<TeacherView>(s => new TeacherView()
            {
                DataContext = s.GetRequiredService<TeacherViewModel>()
            });
            services.AddSingleton<ParentViewModel>();
            services.AddSingleton<ParentView>(s => new ParentView()
            {
                DataContext = s.GetRequiredService<ParentViewModel>()
            });
            // School classes
            services.AddSingleton<SchoolClassesViewModel>();
            services.AddSingleton<SchoolClassesView>(s => new SchoolClassesView()
            {
                DataContext = s.GetRequiredService<SchoolClassesViewModel>()
            });
            // School subject
            services.AddSingleton<SchoolSubjectsViewModel>();
            services.AddSingleton<SchoolSubjectsView>(s => new SchoolSubjectsView()
            {
                DataContext = s.GetRequiredService<SchoolSubjectsViewModel>()
            });
            services.AddSingleton<SubjectsViewModel>();
            services.AddSingleton<SubjectsView>(s => new SubjectsView()
            {
                DataContext = s.GetRequiredService<SubjectsViewModel>()
            });
            services.AddSingleton<TeacherSubjectsViewModel>();
            services.AddSingleton<TeacherSubjectsView>(s => new TeacherSubjectsView()
            {
                DataContext = s.GetRequiredService<TeacherSubjectsViewModel>()
            });
            services.AddSingleton<SchoolClassSubjectsViewModel>();
            services.AddSingleton<SchoolClassSubjectsView>(s => new SchoolClassSubjectsView()
            {
                DataContext = s.GetRequiredService<SchoolClassSubjectsViewModel>()
            });
            //School Grade
            services.AddSingleton<SchoolGradeViewModel>();
            services.AddSingleton<SchoolGradeView>(s => new SchoolGradeView()
            {
                DataContext = s.GetRequiredService<SchoolGradeViewModel>()
            });
            services.AddSingleton<ClosingEndOfYearGradeViewModel>();
            services.AddSingleton<ClosingEndOfYearGradeView>(s => new ClosingEndOfYearGradeView()
            {
                DataContext = s.GetRequiredService<ClosingEndOfYearGradeViewModel>()              
            });
            services.AddSingleton<ClosingSemesterGradeViewModel>();
            services.AddSingleton<ClosingSemesterGradeView>(s => new ClosingSemesterGradeView()
            {
                DataContext = s.GetRequiredService<ClosingSemesterGradeViewModel>()
            });
            services.AddSingleton<CurrentSchoolHoursViewModel>();
            services.AddSingleton<CurrentSchoolHoursView>(s => new CurrentSchoolHoursView()
            {
                DataContext = s.GetRequiredService<CurrentSchoolHoursViewModel>()
            });
            services.AddSingleton<TaughtClassesViewModel>();
            services.AddSingleton<TaughtClassesView>(s => new TaughtClassesView()
            {
                DataContext = s.GetRequiredService<TaughtClassesViewModel>()
            });

        }
    }
}
