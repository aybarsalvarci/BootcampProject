using Repositories.Abstract;
using Core.Repositories.EntityFramework;
using Repositories.Concreate.EntityFramework.Contexts;
using Entities;
namespace Repositories.Concreate.EntityFramework
{
    public class UserRepository : EfRepositoryBase<User, Guid, BaseDbContext>, IUserRepository
    {
        public UserRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
