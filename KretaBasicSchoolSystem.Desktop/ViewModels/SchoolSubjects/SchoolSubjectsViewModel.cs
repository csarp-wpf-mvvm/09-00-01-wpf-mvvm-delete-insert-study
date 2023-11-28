using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects
{
    public partial class SchoolSubjectsViewModel : BaseViewModel
    {
        private SchoolClassSubjectsViewModel _schoolClassSubjectViewModel;
        private SubjectsViewModel _subjectsViewModel;
        private TeacherSubjectsViewModel _teacherSubjectViewModel;

        public SchoolSubjectsViewModel()
        {
            _subjectsViewModel = new SubjectsViewModel();
            _teacherSubjectViewModel = new TeacherSubjectsViewModel();
            _schoolClassSubjectViewModel = new SchoolClassSubjectsViewModel();

            CurrentChildViewModel = _subjectsViewModel;
        }

        public SchoolSubjectsViewModel(
            SubjectsViewModel schoolSubjectsViewModel,
            TeacherSubjectsViewModel teacherSubjectsViewModel,
            SchoolClassSubjectsViewModel schoolClassSubjectsViewModel
            )
        {
            _subjectsViewModel = schoolSubjectsViewModel;
            _teacherSubjectViewModel = teacherSubjectsViewModel;
            _schoolClassSubjectViewModel = schoolClassSubjectsViewModel;

            CurrentChildViewModel = _subjectsViewModel;
        }

        [ObservableProperty]
        private BaseViewModel _currentChildViewModel;

        [RelayCommand]
        private void ShowSubjectView()
        {
            CurrentChildViewModel = _subjectsViewModel;
        }

        [RelayCommand]
        private void ShowTeacherSubjectsView()
        {
            CurrentChildViewModel = _teacherSubjectViewModel;
        }

        [RelayCommand]
        private void ShowSchoolClassSubjectsView()
        {
            CurrentChildViewModel = _schoolClassSubjectViewModel;
        }

    }
}
