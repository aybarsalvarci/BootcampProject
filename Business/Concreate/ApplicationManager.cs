using Azure;
using Business.Abstract;
using Business.Dtos.Requests.Application;
using Business.Dtos.Responses.Application;
using Business.Dtos.Responses.Blacklist;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class ApplicationManager : IApplicationService
    {
        private IApplicationRepository _repository;
        public ApplicationManager(IApplicationRepository repository)
        {
            _repository = repository;
        }

        public CreatedApplicationResponse Create(CreateApplicationRequest request)
        {
            Application application = new Application
            {
                ApplicantId = request.ApplicantId,
                BootcampId = request.BootcampId,
                State = request.State
            };

            var response = _repository.Add(application);

            return new CreatedApplicationResponse
            {
                Id = response.Id,
                ApplicantId = response.ApplicantId,
                BootcampId = response.BootcampId,
                State = response.State
            };
        }

        public DeletedApplicationResponse Delete(DeleteApplicationRequest request)
        {
            Application application = new Application
            {
                ApplicantId = request.ApplicantId,
                BootcampId = request.BootcampId,
                State = request.State
            };

            var response = _repository.Delete(application);

            return new DeletedApplicationResponse
            {
                Id = response.Id,
                ApplicantId = response.ApplicantId,
                BootcampId = response.BootcampId,
                State = response.State
            };
        }

        public List<GetListApplicationResponse> GetAll()
        {
            List<Application> applications= _repository.GetAll();
            List<GetListApplicationResponse> responses = new List<GetListApplicationResponse>();
            foreach(var application in applications)
            {
                GetListApplicationResponse response = new GetListApplicationResponse
                {
                    Id = application.Id,
                    ApplicantId = application.ApplicantId,
                    BootcampId = application.BootcampId,
                    State = application.State
                };
                responses.Add(response);
            }

            return responses;
        }

        public GetSingleApplicationResponse GetById(Guid id)
        {
            Application application = _repository.Get(x => x.Id == id);

            return new GetSingleApplicationResponse
            {
                Id = application.Id,
                ApplicantId = application.ApplicantId,
                BootcampId = application.BootcampId,
                State = application.State
            };

        }

        public UpdatedApplicationResponse Update(UpdateApplicationRequest request)
        {
            Application application = new Application
            {
                ApplicantId = request.ApplicantId,
                BootcampId = request.BootcampId,
                State = request.State
            };

            var response = _repository.Update(application);

            return new UpdatedApplicationResponse
            {
                ApplicantId = response.ApplicantId,
                BootcampId = response.BootcampId,
                State = response.State
            };
        }
    }
}
