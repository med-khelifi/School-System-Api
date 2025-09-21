using MediatR;
using SS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Application.Features.Student.Queries.GetAllStudentsQuery
{
    public record GetAllStudentQuery():IRequest<IEnumerable<Core.Entities.Student>>;
   
}
