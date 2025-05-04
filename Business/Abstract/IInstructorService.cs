using Business.Dtos.Requests.Instructor;
using Business.Dtos.Responses.Instructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInstructorService
    {
        GetSingleInstructorResponse GetById(Guid id);
        List<GetListInstructorResponse> GetAll();
        CreatedInstructorResponse Create(CreateInstructorRequest request);
        UpdatedInstructorResponse Update(UpdateInstructorRequest request);
        DeletedInstructorResponse Delete(DeleteInstructorRequest request);
    }
}
