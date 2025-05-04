using Business.Abstract;
using Business.Dtos.Requests.Instructor;
using Business.Dtos.Responses.Instructor;
using Entities;
using Repositories.Abstract;

namespace Business.Concreate
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorRepository _repository;
        public InstructorManager(IInstructorRepository repository)
        {
            _repository = repository;
        }

        public CreatedInstructorResponse Create(CreateInstructorRequest request)
        {
            Instructor employee = new Instructor
            {
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                NationalIdentity = request.NationalIdentity,
                DateOfBirth = request.DateOfBirth,
                Email = request.LastName,
                Password = request.Password,
                CompanyName = request.CompanyName,

            };

            var result = _repository.Add(employee);

            return new CreatedInstructorResponse
            {
                Id = result.Id,
                UserName = result.UserName,
                FirstName = result.FirstName,
                LastName = result.LastName,
                NationalIdentity = result.NationalIdentity,
                DateOfBirth = result.DateOfBirth,
                Email = result.LastName,
                CompanyName = request.CompanyName,
                CreatedDate = result.CreatedDate,
                UpdatedDate = result.UpdatedDate,
            };
        }

        public DeletedInstructorResponse Delete(DeleteInstructorRequest request)
        {
            Instructor instructor = new Instructor
            {
                Id = request.Id,
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                NationalIdentity = request.NationalIdentity,
                DateOfBirth = request.DateOfBirth,
                Email = request.LastName,
                CompanyName = request.CompanyName,

            };

            var result = _repository.Add(instructor);

            return new DeletedInstructorResponse
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

        public List<GetListInstructorResponse> GetAll()
        {
            List<Instructor> employees = _repository.GetAll();
            List<GetListInstructorResponse> responses = new List<GetListInstructorResponse>();
            foreach(var employee in employees)
            {
                GetListInstructorResponse response = new GetListInstructorResponse
                {
                    Id = employee.Id,
                    UserName = employee.UserName,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    NationalIdentity = employee.NationalIdentity,
                    DateOfBirth = employee.DateOfBirth,
                    Email = employee.LastName,
                    CompanyName = employee.CompanyName,
                    CreatedDate = employee.CreatedDate,
                    UpdatedDate = employee.UpdatedDate,
                };

                responses.Add(response);
            }

            return responses;   
        }

        public GetSingleInstructorResponse GetById(Guid id)
        {
            Instructor instructor = _repository.Get(x => x.Id == id);
            return new GetSingleInstructorResponse
            {
                Id = instructor.Id,
                UserName = instructor.UserName,
                FirstName = instructor.FirstName,
                LastName = instructor.LastName,
                NationalIdentity = instructor.NationalIdentity,
                DateOfBirth = instructor.DateOfBirth,
                Email = instructor.LastName,
                CompanyName = instructor.CompanyName,
                CreatedDate = instructor.CreatedDate,
                UpdatedDate = instructor.UpdatedDate,
            };
        }

        public UpdatedInstructorResponse Update(UpdateInstructorRequest request)
        {
            Instructor employee = new Instructor
            {
                Id = request.Id,
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                NationalIdentity = request.NationalIdentity,
                DateOfBirth = request.DateOfBirth,
                Email = request.LastName,
                CompanyName = request.CompanyName,
            };

            var result = _repository.Add(employee);

            return new UpdatedInstructorResponse
            {
                Id = employee.Id,
                UserName = employee.UserName,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                NationalIdentity = employee.NationalIdentity,
                DateOfBirth = employee.DateOfBirth,
                Email = employee.LastName,
                CompanyName = employee.CompanyName,
                CreatedDate = employee.CreatedDate,
                UpdatedDate = employee.UpdatedDate,
            };
        }
    }
}
