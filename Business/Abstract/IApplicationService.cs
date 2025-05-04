using Business.Dtos.Requests.Application;
using Business.Dtos.Responses.Application;
using Business.Dtos.Responses.Blacklist;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicationService
    {
        public List<GetListApplicationResponse> GetAll();
        public GetSingleApplicationResponse GetById(Guid id);
        public CreatedApplicationResponse Create(CreateApplicationRequest request);
        public UpdatedApplicationResponse Update(UpdateApplicationRequest request);
        public DeletedApplicationResponse Delete(DeleteApplicationRequest request);

    }
}
