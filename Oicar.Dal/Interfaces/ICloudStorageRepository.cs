using Oicar.Dal.Entities;
using System.Collections.Generic;

namespace Oicar.Dal.Interfaces
{
    public interface ICloudStorageRepository : IRepository<CloudStorage>
    {
        List<CloudStorage> GetCheapestCloud(CloudStorage cloudStorage);
    }
}
