using SS.Application.Responses.StudentResponses;
using SS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Application.Mappings.StudentMappers
{
    public partial class StudentMapperProfile
    {
        void GetStudentMapper()
        {
            CreateMap<Student, GetStudentResponce>()
                .ForMember(des => des.DepartmentName, opt => opt.MapFrom(src => src.Department.DName));
        }
    }
}
