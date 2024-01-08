using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using System.Collections.Generic;
using System.Linq;
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
                List<StudentDto>? result = await _httpClient.GetFromJsonAsync<List<StudentDto>>("api/Student");
                if (result is object)
                    return result.Select(studentDto => studentDto.ToStudent()).ToList();
            }
            return new List<Student>();
        }
    }
}
