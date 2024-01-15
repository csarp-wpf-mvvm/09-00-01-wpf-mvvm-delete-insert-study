using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Responses;
using Newtonsoft.Json;
using System;
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

        public async Task<ControllerResponse> Update(StudentDto studentDto)
        {
            ControllerResponse defaultResponse = new();
            if (_httpClient is not null)
            {
                try
                {
                    HttpResponseMessage httpResponse = await _httpClient.PutAsJsonAsync("api/Student", studentDto);
                    string content = await httpResponse.Content.ReadAsStringAsync();
                    ControllerResponse? response = JsonConvert.DeserializeObject<ControllerResponse>(content);
                    if (response is not null)
                    {
                        if (response.IsSuccess)
                        {
                            return defaultResponse;
                        }
                        else
                        {
                            Console.WriteLine($"{response.Error}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
            defaultResponse.ClearAndAddError("Az adatok frissítés nem lehetséges!");
            return defaultResponse;
        }
    }
}
