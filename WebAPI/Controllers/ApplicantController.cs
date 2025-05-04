using Business.Abstract;
using Business.Dtos.Requests.Applicant;
using Business.Dtos.Responses.Applicant;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantController : ControllerBase
    {
        private readonly IApplicantService _service;
        public ApplicantController(IApplicantService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public ActionResult<GetSingleApplicantResponse> GetById(Guid id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpGet]
        public ActionResult<List<GetListApplicantResponse>> GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpPost]
        public ActionResult<CreatedApplicantResponse> Create(CreateApplicantRequest request)
        {
            return Created("", _service.Add(request));
        }

        [HttpPut]
        public ActionResult<UpdatedApplicantResponse> Update(UpdateApplicantRequest request)
        {
            return Ok(_service.Update(request));
        }

    }
}
