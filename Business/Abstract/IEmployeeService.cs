using Business.Dtos.Requests.Bootcamp;
using Business.Dtos.Requests.Employee;
using Business.Dtos.Responses.Bootcamp;
using Business.Dtos.Responses.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        GetSingleEmployeeResponse GetById(Guid id);
        List<GetListEmployeeResponse> GetAll();
        CreatedEmployeeResponse Create(CreateEmployeeRequest request);
        UpdatedEmployeeResponse Update(UpdateEmployeeRequest request);
        DeletedEmployeeResponse Delete(DeleteEmployeeRequest request);
    }
}
