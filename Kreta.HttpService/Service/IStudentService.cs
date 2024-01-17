using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Kreta.Shared.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kreta.HttpService.Service
{
    public interface IStudentService
    {
        public Task<List<Student>> SelectAllStudent();
        public Task<ControllerResponse> Update(StudentDto studentDto);
        public Task<ControllerResponse> DeleteAsync(Guid id);
        public Task<ControllerResponse> InsertAsync(Student student);
    }
}
