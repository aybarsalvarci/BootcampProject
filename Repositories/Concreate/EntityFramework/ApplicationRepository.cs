using Core.Repositories.EntityFramework;
using Entities;
using Repositories.Concreate.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concreate.EntityFramework
{
    public class ApplicationRepository : EfRepositoryBase<Application, Guid, BaseDbContext>
    {
        public ApplicationRepository(BaseDbContext context) : base(context)
        {
            //
        }
    }
}
