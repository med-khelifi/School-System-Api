using Microsoft.EntityFrameworkCore;
using SS.Core.Entities;
using SS.Core.Interfaces;
using SS.Infrastructure.appDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Infrastructure.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(SchoolDbContext context) : base(context)
        {
           
        }
    }
}
