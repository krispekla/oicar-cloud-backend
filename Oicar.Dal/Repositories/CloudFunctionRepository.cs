using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;

namespace Oicar.Dal.Repositories
{
    public class CloudFunctionRepository : Repository<CloudFunction>, ICloudFunctionRepository
    {
        public CloudFunctionRepository(OicarContext context) : base(context)
        {}

        public OicarContext OicarContext
        {
            get { return Context as OicarContext; }
        }
    }
}
