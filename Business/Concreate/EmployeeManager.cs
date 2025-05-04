using Business.Abstract;
using Business.Dtos.Requests.Bootcamp;
using Business.Dtos.Requests.Employee;
using Business.Dtos.Responses.Bootcamp;
using Business.Dtos.Responses.Employee;
using Entities;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeManager(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public CreatedEmployeeResponse Create(CreateEmployeeRequest request)
        {
            Employee employee = new Employee
            {
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                NationalIdentity = request.NationalIdentity,
                DateOfBirth = request.DateOfBirth,
                Email = request.LastName,
                Password = request.Password,
                Position = request.Position,

            };

            var result = _repository.Add(employee);

            return new CreatedEmployeeResponse
            {
                Id = result.Id,
                UserName = result.UserName,
                FirstName = result.FirstName,
                LastName = result.LastName,
                NationalIdentity = result.NationalIdentity,
                DateOfBirth = result.DateOfBirth,
                Email = result.LastName,
                Position = result.Position,
                CreatedDate = result.CreatedDate,
                UpdatedDate = result.UpdatedDate,
            };
        }

        public DeletedEmployeeResponse Delete(DeleteEmployeeRequest request)
        {
            Employee employee = new Employee
            {
                Id = request.Id,
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                NationalIdentity = request.NationalIdentity,
                DateOfBirth = request.DateOfBirth,
                Email = request.LastName,
                Position = request.Position,

            };

            var result = _repository.Add(employee);

            return new DeletedEmployeeResponse
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

        public List<GetListEmployeeResponse> GetAll()
        {
            List<Employee> employees = _repository.GetAll();
            List<GetListEmployeeResponse> responses = new List<GetListEmployeeResponse>();
            foreach(var employee in employees)
            {
                GetListEmployeeResponse response = new GetListEmployeeResponse
                {
                    Id = employee.Id,
                    UserName = employee.UserName,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    NationalIdentity = employee.NationalIdentity,
                    DateOfBirth = employee.DateOfBirth,
                    Email = employee.LastName,
                    Position = employee.Position,
                    CreatedDate = employee.CreatedDate,
                    UpdatedDate = employee.UpdatedDate,
                };

                responses.Add(response);
            }

            return responses;   
        }

        public GetSingleEmployeeResponse GetById(Guid id)
        {
            Employee employee = _repository.Get(x => x.Id == id);
            return new GetSingleEmployeeResponse
            {
                Id = employee.Id,
                UserName = employee.UserName,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                NationalIdentity = employee.NationalIdentity,
                DateOfBirth = employee.DateOfBirth,
                Email = employee.LastName,
                Position = employee.Position,
                CreatedDate = employee.CreatedDate,
                UpdatedDate = employee.UpdatedDate,
            };
        }

        public UpdatedEmployeeResponse Update(UpdateEmployeeRequest request)
        {
            Employee employee = new Employee
            {
                Id = request.Id,
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                NationalIdentity = request.NationalIdentity,
                DateOfBirth = request.DateOfBirth,
                Email = request.LastName,
                Position = request.Position,
            };

            var result = _repository.Add(employee);

            return new UpdatedEmployeeResponse
            {
                Id = employee.Id,
                UserName = employee.UserName,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                NationalIdentity = employee.NationalIdentity,
                DateOfBirth = employee.DateOfBirth,
                Email = employee.LastName,
                Position = employee.Position,
                CreatedDate = employee.CreatedDate,
                UpdatedDate = employee.UpdatedDate,
            };
        }
    }
}
