using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SS.Application.Features.Student.Queries.GetAllStudentsQuery;
using SS.Application.Features.Student.Queries.GetStudentQuery;
using SS.Application.Responses.StudentResponses;
using System.Threading.Tasks;

namespace SS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/Student/all")]
        public async Task<IActionResult> GetAllStudent()
        {
            var response = await _mediator.Send(new GetAllStudentQuery());
            if(response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpGet("/Student/{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var response = await _mediator.Send(new GetStudentQuery(id));
            if(response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
    }
}
