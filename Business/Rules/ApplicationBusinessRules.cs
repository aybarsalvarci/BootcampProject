using Core.Exceptions.Types;
using Core.Rules;
using Entities.Enums;
using Repositories.Abstract;

namespace Business.Rules
{
    public class ApplicationBusinessRules : BaseBusinessRules
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly IBootcampRepository _bootcampRepository;
        public ApplicationBusinessRules(IApplicationRepository applicationRepository, IBootcampRepository bootcampRepository)
        {
            _applicationRepository = applicationRepository;
            _bootcampRepository = bootcampRepository;
        }

        public void isApplied(Guid applicantId, Guid bootcampId)
        {
            var application = _applicationRepository.Get(a => a.ApplicantId == applicantId &&  a.BootcampId == bootcampId);
            if (application is not null)
            {
                throw new BusinessException("Her kullanıcı bir bootcamp için yalnızca bir başvuru yapabilir.");
            }
        }

        public void isBootcampActive(BootcampState state)
        {
            if(state != BootcampState.OPEN_FOR_APPLICATION)
            {
                throw new BusinessException("Bu bootcamp için başvuru kabul edilmiyor.");
            }
        }
    }
}
