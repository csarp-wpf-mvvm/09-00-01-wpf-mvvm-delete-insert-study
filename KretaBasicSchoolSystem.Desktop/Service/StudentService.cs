using KretaBasicSchoolSystem.Desktop.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.Service
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient _httpClient;

        public StudentService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("KretaApi");
        }

        public Task<List<Student>> SelectAllStudent()
        {
            throw new System.NotImplementedException();
        }
    }
}
