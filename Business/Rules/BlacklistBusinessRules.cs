using Core.Exceptions.Types;
using Core.Rules;
using Repositories.Abstract;

namespace Business.Rules
{
    public class BlacklistBusinessRules : BaseBusinessRules
    {
        private readonly IBlacklistRepository _blacklistRepository;

        public BlacklistBusinessRules(IBlacklistRepository blacklistRepository)
        {
            _blacklistRepository = blacklistRepository;
        }

        public void isAlreadyBlackListed(Guid id)
        {
            var blacklist = _blacklistRepository.Get(b => b.ApplicantId == id);

            if (blacklist != null)
            {
                throw new BusinessException("Kullanıcı zaten karalistede.");
            }
        }

        public void reasonNotBeNull(string reason)
        {
            if (reason is null)
                throw new BusinessException("Sebep boş bırakılamaz.");
        }

    }
}
