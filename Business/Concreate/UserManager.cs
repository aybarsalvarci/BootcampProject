using Business.Abstract;
using Business.Dtos.Requests.Bootcamp;
using Business.Dtos.Requests.Employee;
using Business.Dtos.Requests.User;
using Business.Dtos.Responses.Bootcamp;
using Business.Dtos.Responses.Employee;
using Business.Dtos.Responses.User;
using Entities;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _repository;
        public UserManager(IUserRepository repository)
        {
            _repository = repository;
        }

        public CreatedUserResponse Create(CreateUserRequest request)
        {
            User employee = new User
            {
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                NationalIdentity = request.NationalIdentity,
                DateOfBirth = request.DateOfBirth,
                Email = request.LastName,
                Password = request.Password,

            };

            var result = _repository.Add(employee);

            return new CreatedUserResponse
            {
                Id = result.Id,
                UserName = result.UserName,
                FirstName = result.FirstName,
                LastName = result.LastName,
                NationalIdentity = result.NationalIdentity,
                DateOfBirth = result.DateOfBirth,
                Email = result.LastName,
                CreatedDate = result.CreatedDate,
                UpdatedDate = result.UpdatedDate,
            };
        }

        public DeletedUserResponse Delete(DeleteUserRequest request)
        {
            User user = new User
            {
                Id = request.Id,
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                NationalIdentity = request.NationalIdentity,
                DateOfBirth = request.DateOfBirth,
                Email = request.LastName,

            };

            var result = _repository.Add(user);

            return new DeletedUserResponse
            {
                Id = result.Id,
                UserName = result.UserName,
                FirstName = result.FirstName,
                LastName = result.LastName,
                NationalIdentity = result.NationalIdentity,
                DateOfBirth = result.DateOfBirth,
                Email = result.LastName,
                CreatedDate = result.CreatedDate,
                UpdatedDate = result.UpdatedDate,
            };
        }

        public List<GetListUserResponse> GetAll()
        {
            List<User> users = _repository.GetAll();
            List<GetListUserResponse> responses = new List<GetListUserResponse>();
            foreach(var user in users)
            {
                GetListUserResponse response = new GetListUserResponse
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    NationalIdentity = user.NationalIdentity,
                    DateOfBirth = user.DateOfBirth,
                    Email = user.LastName,
                    CreatedDate = user.CreatedDate,
                    UpdatedDate = user.UpdatedDate,
                };

                responses.Add(response);
            }

            return responses;   
        }

        public GetSingleUserResponse GetById(Guid id)
        {
            User user = _repository.Get(x => x.Id == id);
            return new GetSingleUserResponse
            {
                Id = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                NationalIdentity = user.NationalIdentity,
                DateOfBirth = user.DateOfBirth,
                Email = user.LastName,
                CreatedDate = user.CreatedDate,
                UpdatedDate = user.UpdatedDate,
            };
        }

        public UpdatedUserResponse Update(UpdateUserRequest request)
        {
            User user = new User
            {
                Id = request.Id,
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                NationalIdentity = request.NationalIdentity,
                DateOfBirth = request.DateOfBirth,
                Email = request.LastName,
            };

            var result = _repository.Add(user);

            return new UpdatedUserResponse
            {
                Id = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                NationalIdentity = user.NationalIdentity,
                DateOfBirth = user.DateOfBirth,
                Email = user.LastName,
                CreatedDate = user.CreatedDate,
                UpdatedDate = user.UpdatedDate,
            };
        }
    }
}
