using SS.Application.Interfaces;
using SS.Core.Entities;
using SS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _repo.GetAllAsync();
        }
    }
}
