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

        public IEnumerable<CloudDbSQL> GetAllUserCloudDbSQL()
        {
            return Context.Set<UserCloud>().Where(x => x.CloudDbSQL != null).Select(x => x.CloudDbSQL);
        }

        public IEnumerable<CloudFunction> GetAllUserCloudFunctions()
        {
            return Context.Set<UserCloud>().Where(x => x.CloudFunction != null).Select(x => x.CloudFunction);
        }

        public IEnumerable<CloudStorage> GetAllUserCloudStorage()
        {
            return Context.Set<UserCloud>().Where(x => x.CloudStorage != null).Select(x => x.CloudStorage);
        }

        public IEnumerable<CloudVM> GetAllUserCloudVM()
        {
            return Context.Set<UserCloud>().Where(x => x.CloudVM != null).Select(x => x.CloudVM);
        }
    }
}
