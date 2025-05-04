using Core.Repositories.EntityFramework;
using Entities;
using Repositories.Abstract;
using Repositories.Concreate.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concreate.EntityFramework
{
    public class BlacklistRepository : EfRepositoryBase<Blacklist, Guid, BaseDbContext> , IBlacklistRepository
    {
        public BlacklistRepository(BaseDbContext context) : base(context)
        {
                //
        }
    }
}
