using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;

namespace Oicar.Dal.Repositories
{
    public class UserCloudRepository : Repository<UserCloud>, IUserCloudRepository
    {
        public UserCloudRepository(OicarContext context) : base(context)
        { }

        public OicarContext OicarContext
        {
            get { return Context as OicarContext; }
        }

        public IEnumerable<UserCloud> GetAllById(int userId)
        {
            return Context.Set<UserCloud>().Where(x => x.User.Id.Equals(userId))
                .Include(x => x.CloudStorage)
                .Include(z => z.CloudFunction)
                .Include(y => y.CloudDbSQL)
                .Include(g => g.CloudVM);
        }
    }
}
