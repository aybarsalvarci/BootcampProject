using Core.Exceptions.Types;
using Core.Rules;
using Entities;
using Entities.Enums;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Repositories.Abstract;

namespace Business.Rules
{
    public class BootcampBusinessRules : BaseBusinessRules
    {
        private readonly IBootcampRepository _bootcampRepository;
        private readonly IInstructorRepository _instructorRepository;
        public BootcampBusinessRules(IBootcampRepository bootcampRepository, IInstructorRepository instructorRepository)
        {
            _bootcampRepository = bootcampRepository;
            _instructorRepository = instructorRepository;
        }

        public void isStartBeforeFromFinish(DateTime start, DateTime finish)
        {
            if(start >= finish)
            {
                throw new BusinessException("Başlangıç tarihi bitiş tarhinden önce olmalıdır.");
            }
        }

        public void isBootcampAlreadyExists(string name)
        {
            var bootcamp = _bootcampRepository.Get(b => b.Name == name);

            if(bootcamp is not null)
            {
                throw new BusinessException($"{name} adında bir bootcamp daha önce oluşturulmuş.");
            }
        }

        public void isInstructorSigned(Guid id)
        {
            var instructor = _instructorRepository.Get(i => i.Id == id);
            if (instructor is null)
            {
                throw new BusinessException("Eğitmen sisteme kayıtlı değil.");
            }
        }

        public void isBootcampClosed(BootcampState state)
        {
            if (state == BootcampState.CLOSED)
            {
                throw new BusinessException("Bootcamp başvuruya kapalı.");
            }
        }
    }
}
