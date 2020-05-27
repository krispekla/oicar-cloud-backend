using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Oicar.Dal.Repositories
{
    public class CloudFunctionRepository : Repository<CloudFunction>, ICloudFunctionRepository
    {
        public CloudFunctionRepository(OicarContext context) : base(context)
        { }

        public OicarContext OicarContext
        {
            get { return Context as OicarContext; }
        }

        public List<CloudFunction> GetCheapestCloud(CloudFunction cloudFunction)
        {
            var functions = Context.Set<CloudFunction>().Where(x => x.ExecutinPerRequestInMiliseconds >= cloudFunction.ExecutinPerRequestInMiliseconds &&
             x.MemorySizeInMB >= cloudFunction.MemorySizeInMB && x.ExecutionsPerMonth >= cloudFunction.ExecutionsPerMonth).OrderBy(y => y.Price).ToList();

            List<CloudFunction> result = new List<CloudFunction>();

            for (int i = 0; i < functions.Count(); i++)
            {
                if (result.Exists(x => x.CloudProvider == functions.ElementAt(i).CloudProvider)) continue;
                result.Add(functions.ElementAt(i));
                if (result.Count.Equals(3)) break;
            }
            return result;
        }
    }
}
