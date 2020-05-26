using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Oicar.Dal.Repositories
{
    public class CloudStorageRepository : Repository<CloudStorage>, ICloudStorageRepository
    {
        public CloudStorageRepository(OicarContext context) : base(context)
        { }

        public OicarContext OicarContext
        {
            get { return Context as OicarContext; }
        }

        public IEnumerable<CloudStorage> GetCheapestCloud(CloudStorage cloudStorage)
        {
            var functions = Context.Set<CloudStorage>().Where(x => x.TotalAmount >= cloudStorage.TotalAmount &&
         x.ReadOperationsPerMonth >= cloudStorage.ReadOperationsPerMonth && x.WriteOperationsPerMonth >= cloudStorage.WriteOperationsPerMonth).OrderBy(y => y.Price);

            List<CloudStorage> result = new List<CloudStorage>();

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
