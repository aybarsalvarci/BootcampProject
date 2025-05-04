using Core.Repositories.EntityFramework;
using Entities;
using Repositories.Abstract;
using Repositories.Concreate.EntityFramework.Contexts;

namespace Repositories.Concreate.EntityFramework
{
    public class ApplicantRepository : EfRepositoryBase<Applicant, Guid, BaseDbContext>, IApplicantRepository
    {
        public ApplicantRepository(BaseDbContext context) : base(context)
        {
            
        }
    }
}
