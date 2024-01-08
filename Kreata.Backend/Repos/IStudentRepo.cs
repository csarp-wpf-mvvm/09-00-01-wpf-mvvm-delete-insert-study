using Kreta.Shared.Models;
using Kreta.Shared.Responses;

namespace Kreata.Backend.Repos
{
    public interface IStudentRepo
    {
        Task<List<Student>> GetAll();
        Task<Student?> GetBy(Guid id);
        Task<ControllerResponse> UpdateStudentAsync(Student student);
    }
}
