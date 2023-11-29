using KretaBasicSchoolSystem.Desktop.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.Service
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient? _httpClient;

        public StudentService(IHttpClientFactory? httpClientFactory)
        {
            if (httpClientFactory is not null)
            {
                _httpClient = httpClientFactory.CreateClient("KretaApi");
            }
        }

        public async Task<List<Student>> SelectAllStudent()
        {
            if (_httpClient is object)
            {
                List<Student>? result = await _httpClient.GetFromJsonAsync<List<Student>>("api/Student");
                if (result is object)
                    return result;
            }
            return new List<Student>();
        }
    }
}
