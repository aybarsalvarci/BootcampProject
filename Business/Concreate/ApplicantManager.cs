using AutoMapper;
using Business.Abstract;
using Business.Dtos.Requests.Applicant;
using Business.Dtos.Requests.Application;
using Business.Dtos.Responses.Applicant;
using Business.Dtos.Responses.Application;
using Business.Rules;
using Entities;
using Repositories.Abstract;

namespace Business.Concreate
{
    public class ApplicantManager : IApplicantService
    {
        private readonly IApplicantRepository _repository;
        private readonly IMapper _mapper;
        private readonly ApplicantBusinessRules _rules;
        public ApplicantManager(IApplicantRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CreatedApplicantResponse Add(CreateApplicantRequest request)
        {
            Applicant applicant = _mapper.Map<Applicant>(request);

            var result = _repository.Add(applicant);

            return _mapper.Map<CreatedApplicantResponse>(result);
        }

        public DeletedApplicantResponse Delete(DeleteApplicantRequest request)
        {
            Applicant applicant = _mapper.Map<Applicant>(request);

            _rules.isApplicantSigned(applicant.Id);

            return _mapper.Map<DeletedApplicantResponse>(applicant);
        }

        public List<GetListApplicantResponse> GetAll()
        {
            List<Applicant> applicants = _repository.GetAll();
            List<GetListApplicantResponse> responses = _mapper.Map<List<GetListApplicantResponse>>(applicants);
            
            return responses;
        }

        public GetSingleApplicantResponse GetById(Guid id)
        {
            Applicant singleApplicant = _repository.Get(x => x.Id == id);

            return _mapper.Map<GetSingleApplicantResponse>(singleApplicant);
        }

        public UpdatedApplicantResponse Update(UpdateApplicantRequest request)
        {
            Applicant applicantToUpdate = _mapper.Map<Applicant>(request);

            _rules.isApplicantSigned(applicantToUpdate.Id);

            var updateResult = _repository.Update(applicantToUpdate);

            return _mapper.Map<UpdatedApplicantResponse>(updateResult);
        }
    }
}
