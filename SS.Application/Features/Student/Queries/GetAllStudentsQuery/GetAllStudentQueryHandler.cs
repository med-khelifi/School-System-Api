using MediatR;
using SS.Application.Interfaces;
using SS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Application.Features.Student.Queries.GetAllStudentsQuery
{
    public class GetAllStudentQueryHandler : IRequestHandler<GetAllStudentQuery, IEnumerable<Core.Entities.Student>>
    {
        private readonly IStudentService _service;

        public GetAllStudentQueryHandler(IStudentService service)
        {
            _service = service;
        }
        public Task<IEnumerable<Core.Entities.Student>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            //if(cancellationToken.IsCancellationRequested)
            //    return new List<CC>() as IEnumerable<S>;
            return _service.GetAllStudentsAsync();
        }
    }
}
