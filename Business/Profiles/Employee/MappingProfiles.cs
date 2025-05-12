using AutoMapper;
using Business.Dtos.Requests.Employee;
using Business.Dtos.Responses.Employee;

namespace Business.Profiles.Employee
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Entities.Employee, CreateEmployeeRequest>().ReverseMap();
            CreateMap<Entities.Employee, UpdateEmployeeRequest>().ReverseMap();
            CreateMap<Entities.Employee, DeleteEmployeeRequest>().ReverseMap();
            CreateMap<Entities.Employee, CreatedEmployeeResponse>().ReverseMap();
            CreateMap<Entities.Employee, DeletedEmployeeResponse>().ReverseMap();
            CreateMap<Entities.Employee, GetListEmployeeResponse>().ReverseMap();
            CreateMap<Entities.Employee, GetSingleEmployeeResponse>().ReverseMap();
            CreateMap<Entities.Employee, UpdatedEmployeeResponse>().ReverseMap();
        }
    }
}
