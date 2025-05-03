using Core.Repositories.EntityFramework;
using Entities;
using Repositories.Abstract;
using Repositories.Concreate.EntityFramework.Contexts;

namespace Repositories.Concreate.EntityFramework
{
    public class InstructorRepository : EfRepositoryBase<Instructor, Guid, BaseDbContext>, IInstructorRepository
    {
        public InstructorRepository(BaseDbContext context) : base(context)
        {
            
        }
    }
}
