using MediatR;
using SS.Application.Common.Response;
using SS.Application.Responses.StudentResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Application.Features.Student.Queries.GetStudentQuery
{
   public record  GetStudentQuery : IRequest<Response<GetStudentResponce>>
    {
        public GetStudentQuery(int studentID)
        {
            this.studentID = studentID;
        }
        public int studentID;
    }
}
