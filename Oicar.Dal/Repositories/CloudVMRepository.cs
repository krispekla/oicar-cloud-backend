using System.Collections.Generic;
using System.Linq;
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

        public List<CloudVM> GetCheapestCloud(CloudVM cloudVM)
        {
            var functions = Context.Set<CloudVM>().Where(x => x.InstanceNb >= cloudVM.InstanceNb &&
                   x.OperatingSystem.Equals(cloudVM.OperatingSystem) && x.Core >= cloudVM.Core && x.Ram >= cloudVM.Ram &&
                   x.Storage >= cloudVM.Storage && x.StorageType.Equals(cloudVM.StorageType) &&
                   x.AverageDaysPerWeek >= cloudVM.AverageDaysPerWeek && x.AverageHoursPerDay >= cloudVM.AverageHoursPerDay)
                    .OrderBy(y => y.Price).ToList();

            List<CloudVM> result = new List<CloudVM>();

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
