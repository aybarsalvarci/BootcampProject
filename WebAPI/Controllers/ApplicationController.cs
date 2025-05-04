using Business.Abstract;
using Business.Dtos.Requests.Application;
using Business.Dtos.Responses.Application;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private IApplicationService _service;
        public ApplicationController(IApplicationService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<GetListApplicationResponse>> GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<GetListApplicationResponse> GetById(Guid id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public ActionResult<CreatedApplicationResponse> Create(CreateApplicationRequest request)
        {
            return Created("", _service.Create(request));
        }
        [HttpPut]
        public ActionResult<UpdatedApplicationResponse> Update(UpdateApplicationRequest request)
        {
            return Ok(_service.Update(request));
        }

        [HttpDelete]
        public ActionResult<DeletedApplicationResponse> Delete(DeleteApplicationRequest request)
        {
            return Ok(_service.Delete(request));

        }
    } 
}
