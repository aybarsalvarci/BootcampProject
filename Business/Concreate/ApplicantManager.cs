using Business.Abstract;
using Business.Dtos.Requests.Applicant;
using Business.Dtos.Responses.Applicant;
using Core.Repositories;
using Entities;
using Repositories.Abstract;
using Repositories.Concreate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class ApplicantManager : IApplicantService
    {
        private readonly IApplicantRepository _repository;
        public ApplicantManager(IApplicantRepository repository)
        {
            _repository = repository;
        }

        public CreatedApplicantResponse Add(CreateApplicantRequest request)
        {
            Applicant applicant = new Applicant
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                NationalIdentity = request.NationalIdentity,
                DateOfBirth = request.DateOfBirth,
                Email = request.Email,
                Password = request.Password,
                About = request.About,
            };

            var result = _repository.Add(applicant);

            return new CreatedApplicantResponse
            {
                Id = result.Id,
                FirstName = result.FirstName,
                LastName = result.LastName,
                UserName = result.UserName,
                NationalIdentity = result.NationalIdentity,
                DateOfBirth = result.DateOfBirth,
                Email = result.Email,
                About = result.About,
                CreatedDate = result.CreatedDate
            };
        }

        public Applicant Delete(Applicant applicant)
        {
            return _repository.Delete(applicant);
        }

        public List<GetListApplicantResponse> GetAll()
        {
            List<Applicant> applicants = _repository.GetAll();
            List<GetListApplicantResponse> responses = new List<GetListApplicantResponse>();
            foreach(var applicant in applicants)
            {
                GetListApplicantResponse dto = new GetListApplicantResponse
                {
                    Id = applicant.Id,
                    FirstName = applicant.FirstName,
                    LastName = applicant.LastName,
                    UserName = applicant.UserName,
                    NationalIdentity = applicant.NationalIdentity,
                    CreatedDate = applicant.CreatedDate,
                    UpdatedDate = applicant.UpdatedDate,
                    Email = applicant.Email
                };
                responses.Add(dto);
            }

            return responses;
        }

        public GetSingleApplicantResponse GetById(Guid id)
        {
            Applicant singleApplicant = _repository.Get(x => x.Id == id);

            return new GetSingleApplicantResponse
            {
                UserName = singleApplicant.UserName,
                FirstName = singleApplicant.FirstName,
                LastName = singleApplicant.LastName,
                NationalIdentity = singleApplicant.NationalIdentity,
                DateOfBirth = singleApplicant.DateOfBirth,
                Email = singleApplicant.Email,
                About = singleApplicant.About
            };
        }

        public UpdatedApplicantResponse Update(UpdateApplicantRequest request)
        {
            Applicant applicantToUpdate = new Applicant
            {
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                NationalIdentity = request.NationalIdentity,
                DateOfBirth = request.DateOfBirth,
                Email = request.Email,
                Password = request.Password,
                About = request.About
            };

            var updateResult = _repository.Update(applicantToUpdate);

            return new UpdatedApplicantResponse
            {
                UserName = updateResult.UserName,
                FirstName = updateResult.FirstName,
                LastName = updateResult.LastName,
                NationalIdentity = updateResult.NationalIdentity,
                DateOfBirth = updateResult.DateOfBirth,
                Email = updateResult.Email,
                About = updateResult.About
            };
        }
    }
}
