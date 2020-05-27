using System.Collections.Generic;
using System.Linq;
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

        public List<CloudDbSQL> GetCheapestCloud(CloudDbSQL cloudDbSQL)
        {
            var functions = Context.Set<CloudDbSQL>().Where(x => x.Instance >= cloudDbSQL.Instance &&
                    x.Ram >= cloudDbSQL.Ram && x.CpuCores >= cloudDbSQL.CpuCores && x.BaskupSize >= cloudDbSQL.BaskupSize &&
                        x.AverageDaysPerWeek >= cloudDbSQL.AverageDaysPerWeek &&
                        x.AverageHoursPerDay >= cloudDbSQL.AverageHoursPerDay && x.SQLServerType.Equals(cloudDbSQL.SQLServerType))
                        .OrderBy(y => y.Price).ToList();

            List<CloudDbSQL> result = new List<CloudDbSQL>();

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
