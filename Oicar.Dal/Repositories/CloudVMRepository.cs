using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;

namespace Oicar.Dal.Repositories
{
    public class CloudVMRepository : Repository<CloudVM>, ICloudVMRepository
    {
        public CloudVMRepository(OicarContext context) : base(context)
        {}

        public OicarContext OicarContext
        {
            get { return Context as OicarContext; }
        }
    }
}
