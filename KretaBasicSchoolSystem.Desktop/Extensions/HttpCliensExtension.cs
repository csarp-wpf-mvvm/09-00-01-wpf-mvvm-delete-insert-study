using Microsoft.Extensions.DependencyInjection;
using System;

namespace KretaBasicSchoolSystem.Desktop.Extensions
{
    public static class HttpCliensExtension
    {
        public static void ConfigureHttpCliens(this IServiceCollection services)
        {
            services.AddHttpClient("KretaApi", options =>
            {
                options.BaseAddress = new Uri("https://localhost:7090/");
            });
        }

    }
}
