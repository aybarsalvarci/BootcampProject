using Business.Dtos.Requests.Instructor;
using Business.Dtos.Requests.User;
using Business.Dtos.Responses.Instructor;
using Business.Dtos.Responses.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        GetSingleUserResponse GetById(Guid id);
        List<GetListUserResponse> GetAll();
        CreatedUserResponse Create(CreateUserRequest request);
        UpdatedUserResponse Update(UpdateUserRequest request);
        DeletedUserResponse Delete(DeleteUserRequest request);
    }
}
