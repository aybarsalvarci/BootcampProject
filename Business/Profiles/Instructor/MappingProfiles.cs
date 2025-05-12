using AutoMapper;
using Business.Dtos.Requests.Instructor;
using Business.Dtos.Responses.Instructor;

namespace Business.Profiles.Instructor
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Entities.Instructor, CreateInstructorRequest>().ReverseMap();
            CreateMap<Entities.Instructor, UpdateInstructorRequest>().ReverseMap();
            CreateMap<Entities.Instructor, DeleteInstructorRequest>().ReverseMap();
            CreateMap<Entities.Instructor, CreatedInstructorResponse>().ReverseMap();
            CreateMap<Entities.Instructor, DeletedInstructorResponse>().ReverseMap();
            CreateMap<Entities.Instructor, GetListInstructorResponse>().ReverseMap();
            CreateMap<Entities.Instructor, GetSingleInstructorResponse>().ReverseMap();
            CreateMap<Entities.Instructor, UpdatedInstructorResponse>().ReverseMap();

        }
    }
}
