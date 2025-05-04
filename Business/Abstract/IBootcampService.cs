using Business.Dtos.Requests.Bootcamp;
using Business.Dtos.Responses.Bootcamp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBootcampService
    {
        GetSingleBootcampResponse GetById(Guid id);
        List<GetListBootcampResponse> GetAll();
        CreatedBootcampResponse Create(CreateBootcampRequest request);
        UpdatedBootcampResponse Update(UpdateBootcampRequest request);
        DeletedBootcampResponse Delete(DeleteBootcampRequest request);
    }
}
