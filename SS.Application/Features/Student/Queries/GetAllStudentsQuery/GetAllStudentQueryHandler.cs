using AutoMapper;
using MediatR;
using SS.Application.Common.Response;
using SS.Application.Interfaces;
using SS.Application.Responses.StudentResponses;


namespace SS.Application.Features.Student.Queries.GetAllStudentsQuery
{
    public class GetAllStudentQueryHandler :ResponseHandler, IRequestHandler<GetAllStudentQuery, Response<IEnumerable<GetStuentListResponse>>>
    {
        private readonly IStudentService _service;
        private readonly IMapper _mapper;

        public GetAllStudentQueryHandler(IStudentService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<Response<IEnumerable<GetStuentListResponse>>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            var studentsList = await _service.GetAllStudentsAsync();
            var res = _mapper.Map<IEnumerable<GetStuentListResponse>>(studentsList);
            return Success(res);
        }
    }
}
