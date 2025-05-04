using Business.Abstract;
using Business.Dtos.Requests.Instructor;
using Business.Dtos.Responses.Instructor;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        private readonly IInstructorService _service;
        public InstructorController(IInstructorService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<GetListInstructorResponse> Getall()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<GetSingleInstructorResponse> GetById(Guid id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public ActionResult<CreatedInstructorResponse> Create(CreateInstructorRequest request)
        {
            return Created("", _service.Create(request));
        }

        [HttpPut]
        public ActionResult<UpdatedInstructorResponse> Update(UpdateInstructorRequest request)
        {
            return Ok(_service.Update(request));
        }

        [HttpDelete]
        public ActionResult<DeletedInstructorResponse> Delete(DeleteInstructorRequest request)
        {
            return Ok(_service.Delete(request));
        }
    }
}
