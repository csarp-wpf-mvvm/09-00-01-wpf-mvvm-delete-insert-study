using CommunityToolkit.Mvvm.ComponentModel;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects
{
    public partial class SchoolSubjectsViewModel : BaseViewModel
    {
        private SchoolClassSubjectViewModel _schoolClassSubjectViewModel;
        private SubjectsViewModel _subjectsViewModel;
        private TeacherSubjectViewModel _teacherSubjectViewModel;

        public SchoolSubjectsViewModel()
        {
                
        }

        [ObservableProperty]
        private BaseViewModel _currentChildViewModel;

    }
}
