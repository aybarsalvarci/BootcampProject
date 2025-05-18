using Core.Exceptions.Types;
using Core.Rules;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;

namespace Business.Rules
{
    public  class ApplicantBusinessRules : BaseBusinessRules
    {
        private readonly IApplicantRepository _applicantRepository;
        private readonly IBlacklistRepository _blacklistRepository;
        private readonly IApplicationRepository _applicationRepository;
        public ApplicantBusinessRules(IApplicantRepository applicantRepository,
            IBlacklistRepository blacklistRepository,
            IApplicationRepository applicationRepository)
        {
            _applicantRepository = applicantRepository;
            _blacklistRepository = blacklistRepository;
            _applicationRepository = applicationRepository;
        }

        public void isBlacklisted(Guid id)
        {
            var blackList = _blacklistRepository.Get(a => a.Id == id);
            if(blackList is not null)
            {
                throw new BusinessException("Kulanıcı kara listede.");
            }
        }

        public void hasAplication(string identity)
        {
            var applicant = _applicantRepository.Get(a => a.NationalIdentity == identity, include:a=>a.Include(a => a.Applications));
            
            if(applicant.Applications is not null)
            {
                throw new BusinessException($"{applicant.FirstName} daha önce başvuru yapmış.");
            }
        }

        public void isApplicantSigned(Guid id)
        {
            var blackList = _applicantRepository.Get(a => a.Id == id);
            if (blackList is not null)
            {
                throw new BusinessException("Başvuru sahibi sistemde kayıtlı değil.");
            }
        }
    }
}
