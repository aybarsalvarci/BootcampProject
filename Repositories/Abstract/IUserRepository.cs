using Core.Repositories;
using Entities;

namespace Repositories.Abstract
{
    public interface IUserRepository : IRepository<User, Guid>
    {
    }
}
