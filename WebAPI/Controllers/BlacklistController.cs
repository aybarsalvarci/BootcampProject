using Business.Abstract;
using Business.Dtos.Requests.Application;
using Business.Dtos.Responses.Applicant;
using Business.Dtos.Responses.Blacklist;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlacklistController : ControllerBase
    {
        private readonly IBlacklistService _service;
        public BlacklistController(IBlacklistService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<GetListBlacklistResponse>> GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<List<GetListBlacklistResponse>> GetById(Guid id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public ActionResult<CreatedBlacklistResponse> Create(CreateBlacklistRequest request)
        {
            return Created("", _service.Create(request));
        }

        [HttpPut]
        public ActionResult<UpdatedApplicantResponse> Update(UpdateBlacklistRequest request)
        {
            return Ok(_service.Update(request));
        }

        [HttpDelete]
        public ActionResult<DeletedBlacklistResponse> Delete(DeleteBlacklistRequest request)
        {
            return Ok(_service.Delete(request));

        }
    }
}
