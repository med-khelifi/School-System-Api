using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SS.Application.Features.Student.Queries.GetAllStudentsQuery;
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
        public async Task<IActionResult> GellAllStudent()
        {
            var response = await _mediator.Send(new GetAllStudentQuery());
            if(response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
    }
}
