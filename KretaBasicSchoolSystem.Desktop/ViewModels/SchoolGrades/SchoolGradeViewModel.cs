using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolGrades
{
    public partial class SchoolGradeViewModel : BaseViewModel
    {
        private CurrentSchoolHoursViewModel _currentSchoolHoursViewModel;
        private TaughtClassesViewModel _taughtClassesViewModel;
        private ClosingSemesterGradeViewModel _closingSemesterGradeViewModel;
        private ClosingEndOfYearGradeViewModel _closingEndOfYearGradeViewModel;

        public SchoolGradeViewModel()
        {
            CurrentChildViewModel = new CurrentSchoolHoursViewModel();

            _currentSchoolHoursViewModel = new CurrentSchoolHoursViewModel();
            _taughtClassesViewModel = new TaughtClassesViewModel();
            _closingSemesterGradeViewModel = new ClosingSemesterGradeViewModel();
            _closingEndOfYearGradeViewModel = new ClosingEndOfYearGradeViewModel();
        }

        public SchoolGradeViewModel(
            CurrentSchoolHoursViewModel currentSchoolHoursViewModel,
            TaughtClassesViewModel taughtClassesViewModel,
            ClosingSemesterGradeViewModel closingSemesterGradeViewModel,
            ClosingEndOfYearGradeViewModel closingEndOfYearGradeViewModel)
        {
            _currentSchoolHoursViewModel = currentSchoolHoursViewModel;
            _taughtClassesViewModel = taughtClassesViewModel;
            _closingSemesterGradeViewModel = closingSemesterGradeViewModel;
            _closingEndOfYearGradeViewModel = closingEndOfYearGradeViewModel;

            CurrentChildViewModel = new CurrentSchoolHoursViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentChildViewModel;

        [RelayCommand]
        public void ShowCurrentSchoolHours()
        {
            CurrentChildViewModel = _currentSchoolHoursViewModel;
        }

        [RelayCommand]
        public void ShowTaughtClasses()
        {
            CurrentChildViewModel = _taughtClassesViewModel;
        }

        [RelayCommand]
        public void ShowClosingSemesterGrade()
        {
            CurrentChildViewModel = _closingSemesterGradeViewModel;
        }

        [RelayCommand]
        public void SchowClosingEndOfYearGrade()
        {
            CurrentChildViewModel = _closingEndOfYearGradeViewModel;
        }
    }
}
