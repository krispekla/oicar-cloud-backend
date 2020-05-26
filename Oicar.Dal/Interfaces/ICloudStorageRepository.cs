using Oicar.Dal.Entities;
using System.Collections.Generic;

namespace Oicar.Dal.Interfaces
{
    public interface ICloudStorageRepository : IRepository<CloudStorage>
    {
        IEnumerable<CloudStorage> GetCheapestCloud(CloudStorage cloudStorage);
    }
}
