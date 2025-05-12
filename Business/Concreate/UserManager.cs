using AutoMapper;
using Business.Abstract;
using Business.Dtos.Requests.User;
using Business.Dtos.Responses.User;
using Entities;
using Repositories.Abstract;

namespace Business.Concreate
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        public UserManager(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CreatedUserResponse Create(CreateUserRequest request)
        {
            User user = _mapper.Map<User>(request);

            var result = _repository.Add(user);

            return _mapper.Map<CreatedUserResponse>(result);
        }

        public DeletedUserResponse Delete(DeleteUserRequest request)
        {
            User user = _mapper.Map<User>(request);

            var result = _repository.Add(user);

            return _mapper.Map<DeletedUserResponse>(result);
        }

        public List<GetListUserResponse> GetAll()
        {
            List<User> users = _repository.GetAll();
            List<GetListUserResponse> responses = new List<GetListUserResponse>();
            foreach(var user in users)
            {
                responses.Add(_mapper.Map<GetListUserResponse>(user));
            }

            return responses;   
        }

        public GetSingleUserResponse GetById(Guid id)
        {
            User user = _repository.Get(x => x.Id == id);
            return _mapper.Map<GetSingleUserResponse>(user);
        }

        public UpdatedUserResponse Update(UpdateUserRequest request)
        {
            User user = _mapper.Map<User>(request);

            var result = _repository.Add(user);

            return _mapper.Map<UpdatedUserResponse>(result);
        }
    }
}
