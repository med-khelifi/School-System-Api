using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Application.Mappings.StudentMappers
{
    public partial class StudentMapperProfile : Profile
    {
        public StudentMapperProfile()
        {
            GetStudentListMapper();
            GetStudentMapper();

        }
    }
}
