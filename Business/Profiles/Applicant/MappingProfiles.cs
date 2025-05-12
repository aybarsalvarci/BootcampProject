using AutoMapper;
using Business.Dtos.Requests.Applicant;
using Business.Dtos.Responses.Applicant;
using Entities;

namespace Business.Profiles.Brand
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Applicant, CreateApplicantRequest>().ReverseMap();
            CreateMap<Applicant, CreatedApplicantResponse>().ReverseMap();
            CreateMap<Applicant, UpdateApplicantRequest>().ReverseMap();
            CreateMap<Applicant, UpdatedApplicantResponse>().ReverseMap();
            CreateMap<Applicant, DeleteApplicantRequest>().ReverseMap();
            CreateMap<Applicant, DeletedApplicantResponse>().ReverseMap();
            CreateMap<Applicant, GetListApplicantResponse>().ReverseMap();
            CreateMap<Applicant, GetSingleApplicantResponse>().ReverseMap();
        }
    }
}
