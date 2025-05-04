using Business.Abstract;
using Business.Dtos.Requests.User;
using Business.Dtos.Responses.User;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<GetListUserResponse> Getall()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<GetSingleUserResponse> GetById(Guid id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public ActionResult<CreatedUserResponse> Create(CreateUserRequest request)
        {
            return Created("", _service.Create(request));
        }

        [HttpPut]
        public ActionResult<UpdatedUserResponse> Update(UpdateUserRequest request)
        {
            return Ok(_service.Update(request));
        }

        [HttpDelete]
        public ActionResult<DeletedUserResponse> Delete(DeleteUserRequest request)
        {
            return Ok(_service.Delete(request));
        }
    }
}
