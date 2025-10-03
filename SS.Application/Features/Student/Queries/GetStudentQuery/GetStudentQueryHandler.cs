using AutoMapper;
using MediatR;
using SS.Application.Common.Response;
using SS.Application.Interfaces;
using SS.Application.Responses.StudentResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Application.Features.Student.Queries.GetStudentQuery
{

    class GetStudentQueryHandler : ResponseHandler, IRequestHandler<GetStudentQuery, Response<GetStudentResponce>>
    {
        private readonly IMapper _mapper;
        private readonly IStudentService _service;

        public GetStudentQueryHandler(IMapper mapper,IStudentService service)
        {
            _mapper = mapper;
            _service = service;
        }
        public async Task<Response<GetStudentResponce>> Handle(GetStudentQuery request, CancellationToken cancellationToken)
        {
            var student = await _service.GetStudentAsync(request.studentID);
            if (student == null) return NotFound<GetStudentResponce>($"Student With ID: {request.studentID} Not Found");

            var response = _mapper.Map<GetStudentResponce>(student);
            return Success(response);
        }
    }
}
