using SS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Application.Interfaces
{
    public interface IStudentService
    {
        public Task<IEnumerable<Student>> GetAllStudentsAsync();
        public Task<Student?> GetStudentAsync(int studentId);
    }
}
