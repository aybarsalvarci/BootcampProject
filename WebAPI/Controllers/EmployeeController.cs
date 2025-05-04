using Business.Abstract;
using Business.Dtos.Requests.Bootcamp;
using Business.Dtos.Requests.Employee;
using Business.Dtos.Responses.Bootcamp;
using Business.Dtos.Responses.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<GetListEmployeeResponse> Getall()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<GetSingleEmployeeResponse> GetById(Guid id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public ActionResult<CreatedEmployeeResponse> Create(CreateEmployeeRequest request)
        {
            return Created("", _service.Create(request));
        }

        [HttpPut]
        public ActionResult<UpdatedEmployeeResponse> Update(UpdateEmployeeRequest request)
        {
            return Ok(_service.Update(request));
        }

        [HttpDelete]
        public ActionResult<DeletedEmployeeResponse> Delete(DeleteEmployeeRequest request)
        {
            return Ok(_service.Delete(request));
        }
    }
}
