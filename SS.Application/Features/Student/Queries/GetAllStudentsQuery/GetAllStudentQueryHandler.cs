using AutoMapper;
using MediatR;
using SS.Application.Interfaces;
using SS.Application.Responses.StudentResponses;


namespace SS.Application.Features.Student.Queries.GetAllStudentsQuery
{
    public class GetAllStudentQueryHandler : IRequestHandler<GetAllStudentQuery, IEnumerable<GetStuentListResponse>>
    {
        private readonly IStudentService _service;
        private readonly IMapper _mapper;

        public GetAllStudentQueryHandler(IStudentService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        async Task<IEnumerable<GetStuentListResponse>> IRequestHandler<GetAllStudentQuery, IEnumerable<GetStuentListResponse>>.Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            var  studentsList = await _service.GetAllStudentsAsync();
            return _mapper.Map<IEnumerable<GetStuentListResponse>>(studentsList);
        }
    }
}
