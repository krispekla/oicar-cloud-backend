using System.Collections.Generic;
using Oicar.Dal.Entities;

namespace Oicar.Dal.Interfaces
{
    public interface ICloudDbSQLRepository : IRepository<CloudDbSQL>
    {
        List<CloudDbSQL> GetCheapestCloud(CloudDbSQL cloudDbSQL);
    }
}
