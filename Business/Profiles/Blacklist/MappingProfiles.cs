using AutoMapper;
using Business.Dtos.Requests.Application;
using Business.Dtos.Responses.Blacklist;

namespace Business.Profiles.Blacklist
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Entities.Blacklist, CreateBlacklistRequest>().ReverseMap();
            CreateMap<Entities.Blacklist, DeleteBlacklistRequest>().ReverseMap();
            CreateMap<Entities.Blacklist, UpdateBlacklistRequest>().ReverseMap();
            CreateMap<Entities.Blacklist, CreatedBlacklistResponse>().ReverseMap();
            CreateMap<Entities.Blacklist, DeletedBlacklistResponse>().ReverseMap();
            CreateMap<Entities.Blacklist, GetListBlacklistResponse>().ReverseMap();
            CreateMap<Entities.Blacklist, UpdatedBlacklistResponse>().ReverseMap();
            CreateMap<Entities.Blacklist, GetSingleBlacklistResponse>().ReverseMap();
        }
    }
}
