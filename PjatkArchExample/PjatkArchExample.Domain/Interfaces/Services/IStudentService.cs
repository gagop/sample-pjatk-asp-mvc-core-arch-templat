using PjatkArchExample.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PjatkArchExample.Domain.Interfaces.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetStudentsAsync();
        Task AddStudentAsync(Student newStudent);
    }
}
