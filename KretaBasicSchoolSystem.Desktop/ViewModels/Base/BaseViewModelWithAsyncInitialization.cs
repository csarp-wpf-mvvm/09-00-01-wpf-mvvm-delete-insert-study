using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.Base
{
    public class BaseViewModelWithAsyncInitialization : BaseViewModel, IAsyncInitialization
    {
        public virtual Task InitializeAsync()
        {
            return Task.CompletedTask;
        }
    }
}
