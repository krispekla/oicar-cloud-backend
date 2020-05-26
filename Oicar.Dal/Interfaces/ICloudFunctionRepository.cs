using Oicar.Dal.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Oicar.Dal.Interfaces
{
    public interface ICloudFunctionRepository : IRepository<CloudFunction>
    {
        IEnumerable<CloudFunction> GetCheapestCloud(CloudFunction cloudFunction);
    }
}
