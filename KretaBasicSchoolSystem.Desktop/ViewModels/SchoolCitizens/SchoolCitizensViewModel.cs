using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.HttpService.Service;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens
{
    public partial class SchoolCitizensViewModel : BaseViewModel
    {
        private readonly StudentViewModel _studentViewModel;
        private readonly ParentViewModel _parentViewModel;
        private readonly TeacherViewModel _teacherViewModel;

        public SchoolCitizensViewModel()
        {
            IStudentService studentService = new StudentService(null);
            _studentViewModel = new StudentViewModel(studentService);
            _parentViewModel = new ParentViewModel();
            _teacherViewModel = new TeacherViewModel();

            CurrentChildViewModel = new TeacherViewModel();
        }

        public SchoolCitizensViewModel(StudentViewModel studentViewModel, ParentViewModel parentViewModel, TeacherViewModel teacherViewModel)
        {
            _studentViewModel = studentViewModel;
            _parentViewModel = parentViewModel;
            _teacherViewModel = teacherViewModel;

            CurrentChildViewModel = new TeacherViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentChildViewModel;

        [RelayCommand]
        public async Task ShowStudentView()
        {
            await _studentViewModel.InitializeAsync();
            CurrentChildViewModel = _studentViewModel;
        }


        [RelayCommand]
        public void ShowTeacherView()
        {
            CurrentChildViewModel = _teacherViewModel;
        }

        [RelayCommand]
        public void ShowParentView()
        {
            CurrentChildViewModel = _parentViewModel;
        }
    }
}
