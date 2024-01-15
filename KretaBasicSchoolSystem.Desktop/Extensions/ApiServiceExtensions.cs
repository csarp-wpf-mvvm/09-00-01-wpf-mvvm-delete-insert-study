using Kreta.HttpService.Service;
using Microsoft.Extensions.DependencyInjection;

namespace KretaBasicSchoolSystem.Desktop.Extensions
{
    public static class ApiServiceExtensions
    {
        public static void ConfigureApiServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
        }
    }
}
