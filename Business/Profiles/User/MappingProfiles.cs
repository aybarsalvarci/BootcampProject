using AutoMapper;
using Business.Dtos.Requests.User;
using Business.Dtos.Responses.User;

namespace Business.Profiles.User
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Entities.User, CreateUserRequest>().ReverseMap();
            CreateMap<Entities.User, UpdateUserRequest>().ReverseMap();
            CreateMap<Entities.User, DeleteUserRequest>().ReverseMap();
            CreateMap<Entities.User, CreatedUserResponse>().ReverseMap();
            CreateMap<Entities.User, DeletedUserResponse>().ReverseMap();
            CreateMap<Entities.User, GetListUserResponse>().ReverseMap();
            CreateMap<Entities.User, GetSingleUserResponse>().ReverseMap();
            CreateMap<Entities.User, UpdatedUserResponse>().ReverseMap();

        }
    }
}
