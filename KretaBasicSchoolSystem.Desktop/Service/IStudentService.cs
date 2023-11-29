using KretaBasicSchoolSystem.Desktop.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.Service
{
    public interface IStudentService
    {
        public Task<List<Student>> SelectAllStudent();
    }
}
