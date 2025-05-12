using AutoMapper;
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
        private readonly IMapper _mapper;
        public EmployeeManager(IEmployeeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CreatedEmployeeResponse Create(CreateEmployeeRequest request)
        {
            Employee employee = _mapper.Map<Employee>(request);

            var result = _repository.Add(employee);

            return _mapper.Map<CreatedEmployeeResponse>(result);
        }

        public DeletedEmployeeResponse Delete(DeleteEmployeeRequest request)
        {
            Employee employee = _mapper.Map<Employee>(request);

            var result = _repository.Add(employee);

            return _mapper.Map<DeletedEmployeeResponse>(result);
        }

        public List<GetListEmployeeResponse> GetAll()
        {
            List<Employee> employees = _repository.GetAll();
            List<GetListEmployeeResponse> responses = new List<GetListEmployeeResponse>();
            foreach(var employee in employees)
            {
                responses.Add(_mapper.Map<GetListEmployeeResponse>(employee));
            }

            return responses;   
        }

        public GetSingleEmployeeResponse GetById(Guid id)
        {
            Employee employee = _repository.Get(x => x.Id == id);
            return _mapper.Map<GetSingleEmployeeResponse>(employee);
        }

        public UpdatedEmployeeResponse Update(UpdateEmployeeRequest request)
        {
            Employee employee = _mapper.Map<Employee>(request);

            var result = _repository.Add(employee);

            return _mapper.Map<UpdatedEmployeeResponse>(result);
        }
    }
}
