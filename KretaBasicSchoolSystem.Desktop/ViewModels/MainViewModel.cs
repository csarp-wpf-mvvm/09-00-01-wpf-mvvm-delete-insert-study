using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FontAwesome.Sharp;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolGrades;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects;

namespace KretaBasicSchoolSystem.Desktop.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private ControlPanelViewModel _controlPanelViewModel;

        private SchoolClassesViewModel _schoolClassesViewModel;
        private SchoolCitizensViewModel _schoolCitizensViewModel;
        private SchoolSubjectsViewModel _schoolSubjectViewModel;
        private SchoolGradeViewModel _schoolGradeViewModel;

        public MainViewModel()
        {
            _controlPanelViewModel = new ControlPanelViewModel();
            _schoolClassesViewModel = new SchoolClassesViewModel();
            _schoolCitizensViewModel = new SchoolCitizensViewModel();
            _schoolSubjectViewModel = new SchoolSubjectsViewModel();
            _schoolGradeViewModel = new SchoolGradeViewModel();

            CurrentChildView = _controlPanelViewModel;
        }

        public MainViewModel(
            ControlPanelViewModel controlPanelViewModel,
            SchoolCitizensViewModel schoolCitizensViewModel,
            SchoolClassesViewModel schoolClassesViewModel,
            SchoolSubjectsViewModel schoolSubjectsViewModel,
            SchoolGradeViewModel schoolGradeViewModel          
            )
        {
            _controlPanelViewModel = controlPanelViewModel;
            _schoolCitizensViewModel = schoolCitizensViewModel;
            _schoolClassesViewModel = schoolClassesViewModel;
            _schoolSubjectViewModel = schoolSubjectsViewModel;
            _schoolGradeViewModel = schoolGradeViewModel;


            CurrentChildView = _controlPanelViewModel;
        }

        [ObservableProperty]
        private string _caption = string.Empty;

        [ObservableProperty]
        private IconChar _icon = new IconChar();

        [ObservableProperty]
        private BaseViewModel _currentChildView;

        [RelayCommand]
        public void ShowDashbord()
        {
            Caption = "Vezérlőpult";
            Icon = IconChar.SolarPanel;
            CurrentChildView = _controlPanelViewModel;
        }

        [RelayCommand]
        public void ShowSchoolCitizens()
        {
            Caption = "Iskolapolgárok";
            Icon = IconChar.UserGroup;
            CurrentChildView = _schoolCitizensViewModel;
        }

        [RelayCommand]
        public void ShowSchoolClasses()
        {
            Caption = "Osztályok";
            Icon = FontAwesome.Sharp.IconChar.ChalkboardUser;
            CurrentChildView = _schoolClassesViewModel;
;
        }

        [RelayCommand]
        public void SchowSchoolSubject()
        {
            Caption = "Tantárgyak";
            Icon = FontAwesome.Sharp.IconChar.GraduationCap;
            CurrentChildView = _schoolSubjectViewModel;
        }

        [RelayCommand]
        public void ShowSchoolGrade()
        {
            Caption = "Osztályzatok";
            Icon = FontAwesome.Sharp.IconChar.UserGraduate;
            CurrentChildView = _schoolGradeViewModel;
        }
    }
}
