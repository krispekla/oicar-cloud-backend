using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;

namespace Oicar.Dal.Repositories
{
    public class CloudDbSQLRepository : Repository<CloudDbSQL>, ICloudDbSQLRepository
    {
        public CloudDbSQLRepository(OicarContext context) : base(context)
        {}

        public OicarContext OicarContext
        {
            get { return Context as OicarContext; }
        }
    }
}
