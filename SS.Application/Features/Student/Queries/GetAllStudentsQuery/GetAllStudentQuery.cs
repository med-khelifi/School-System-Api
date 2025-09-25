using MediatR;
using SS.Application.Responses.StudentResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Application.Features.Student.Queries.GetAllStudentsQuery
{
    public record GetAllStudentQuery():IRequest<IEnumerable<GetStuentListResponse>>;
   
}
