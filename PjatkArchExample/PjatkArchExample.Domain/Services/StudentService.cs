using PjatkArchExample.Domain.Entities;
using PjatkArchExample.Domain.Interfaces.Repositories;
using PjatkArchExample.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PjatkArchExample.Domain.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _repository;

        public StudentService(IRepository<Student> repository)
        {
            _repository = repository;
        }

        public async Task AddStudentAsync(Student newStudent)
        {
            await _repository.Add(newStudent);
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
