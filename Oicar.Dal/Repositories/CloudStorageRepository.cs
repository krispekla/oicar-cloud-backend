using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;

namespace Oicar.Dal.Repositories
{
    public class CloudStorageRepository : Repository<CloudStorage>, ICloudStorageRepository
    {
        public CloudStorageRepository(OicarContext context) : base(context)
        {}

        public OicarContext OicarContext
        {
            get { return Context as OicarContext; }
        }
    }
}
