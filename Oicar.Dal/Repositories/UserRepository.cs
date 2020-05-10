using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oicar.Dal.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(OicarContext context)
            : base(context)
        {
        }
        public User Get(string id)
        {
            return Context.Set<User>().Find(id);
        }


        public OicarContext OicarContext
        {
            get { return Context as OicarContext; }
        }
    }
}
