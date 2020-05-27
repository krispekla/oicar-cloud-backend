using Oicar.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oicar.Dal.Interfaces
{
    public interface ICloudVMRepository : IRepository<CloudVM>
    {
        List<CloudVM> GetCheapestCloud(CloudVM cloudVM);
    }
}
