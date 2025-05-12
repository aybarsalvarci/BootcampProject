using Business.Dtos.Requests.Applicant;
using Business.Dtos.Responses.Applicant;
using Entities;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        List<GetListApplicantResponse> GetAll();
        GetSingleApplicantResponse GetById(Guid id);
        CreatedApplicantResponse Add(CreateApplicantRequest request);
        UpdatedApplicantResponse Update(UpdateApplicantRequest request);
        DeletedApplicantResponse Delete(DeleteApplicantRequest request);

    }
}
