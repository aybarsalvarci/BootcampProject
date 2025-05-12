using AutoMapper;
using Business.Dtos.Requests.Bootcamp;
using Business.Dtos.Responses.Bootcamp;

namespace Business.Profiles.Bootcamp
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Entities.Bootcamp, CreateBootcampRequest>().ReverseMap();
            CreateMap<Entities.Bootcamp, UpdateBootcampRequest>().ReverseMap();
            CreateMap<Entities.Bootcamp, DeleteBootcampRequest>().ReverseMap();
            CreateMap<Entities.Bootcamp, CreatedBootcampResponse>().ReverseMap();
            CreateMap<Entities.Bootcamp, DeletedBootcampResponse>().ReverseMap();
            CreateMap<Entities.Bootcamp, GetListBootcampResponse>().ReverseMap();
            CreateMap<Entities.Bootcamp, GetSingleBootcampResponse>().ReverseMap();
            CreateMap<Entities.Bootcamp, UpdatedBootcampResponse>().ReverseMap();
        }
    }
}
