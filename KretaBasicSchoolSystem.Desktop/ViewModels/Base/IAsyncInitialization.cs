using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.Base
{
    public interface IAsyncInitialization
    {
        public Task InitializeAsync();
    }
}
