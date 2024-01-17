using Kreta.Shared.Models;
using Kreta.Shared.Responses;

namespace Kreata.Backend.Repos
{
    public interface IStudentRepo
    {
        Task<List<Student>> GetAllAsync();
        Task<Student?> GetByIdAsync(Guid id);
        Task<ControllerResponse> UpdateStudentAsync(Student student);
        Task<ControllerResponse> DeleteStudentAsync(Guid id);
        Task<ControllerResponse> InsertStudentAsync(Student student);
    }
}
