using System;
using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;

namespace Oicar.Dal.Repositories
{
    public class NewsRepository : Repository<NewsPost>, INewsRepository
    {
        public NewsRepository(OicarContext context)
            : base(context)
        {
        }

        public OicarContext OicarContext
        {
            get { return Context as OicarContext; }
        }
    }
}
