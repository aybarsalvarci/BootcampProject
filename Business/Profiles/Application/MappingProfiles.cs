
using AutoMapper;
using Business.Dtos.Requests.Application;
using Business.Dtos.Responses.Application;

namespace Business.Profiles.Application
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Entities.Application, CreateApplicationRequest>().ReverseMap();
            CreateMap<Entities.Application, DeleteApplicationRequest>().ReverseMap();
            CreateMap<Entities.Application, UpdateApplicationRequest>().ReverseMap();
            CreateMap<Entities.Application, CreatedApplicationResponse>().ReverseMap();
            CreateMap<Entities.Application, DeletedApplicationResponse>().ReverseMap();
            CreateMap<Entities.Application, GetListApplicationResponse>().ReverseMap();
            CreateMap<Entities.Application, GetSingleApplicationResponse>().ReverseMap();
            CreateMap<Entities.Application, UpdatedApplicationResponse>().ReverseMap();
        }
    }
}
