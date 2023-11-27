using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolGrade
{
    public partial class SchoolGradeViewModel : BaseViewModel
    {
        private CurrentSchoolHoursViewModel _currentSchoolHoursViewModel;
        private TaughtClassesViewModel _taughtClassesViewModel;
        private ClosingSemesterGradeViewModel _closingSemesterGradeViewModel;
        private ClosingEndOfYearGradeViewModel _closingEndOfYearGradeViewModel;

        public SchoolGradeViewModel()
        {
            _currentSchoolGradeChildView = new CurrentSchoolHoursViewModel();
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

            _currentSchoolGradeChildView = new SchoolGradeViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolGradeChildView;

        [RelayCommand]
        public void ShowAktualisOraView()
        {
            CurrentSchoolGradeChildView = _currentSchoolHoursViewModel;
        }

        [RelayCommand]
        public void ShowTanitottOsztalyokView()
        {
            CurrentSchoolGradeChildView = _taughtClassesViewModel;
        }

        [RelayCommand]
        public void ShowFelevZarasView()
        {
            CurrentSchoolGradeChildView = _closingSemesterGradeViewModel;
        }

        [RelayCommand]
        public void ShowEvVegeZarasView()
        {
            CurrentSchoolGradeChildView = _closingEndOfYearGradeViewModel;
        }
    }
}
