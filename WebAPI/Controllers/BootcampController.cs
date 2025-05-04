using Business.Abstract;
using Business.Dtos.Requests.Bootcamp;
using Business.Dtos.Responses.Bootcamp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BootcampController : ControllerBase
    {
        private readonly IBootcampService _service;
        public BootcampController(IBootcampService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<GetListBootcampResponse> Getall()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<GetSingleBootcampResponse> GetById(Guid id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public ActionResult<CreatedBootcampResponse> Create(CreateBootcampRequest request)
        {
            return Created("", _service.Create(request));
        }

        [HttpPut]
        public ActionResult<UpdatedBootcampResponse> Update(UpdateBootcampRequest request)
        {
            return Ok(_service.Update(request));
        }

        [HttpDelete]
        public ActionResult<DeletedBootcampResponse> Delete(DeleteBootcampRequest request)
        {
            return Ok(_service.Delete(request));
        }
    }
}
