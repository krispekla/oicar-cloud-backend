using System;
using System.Collections.Generic;
using Oicar.Dal.Entities;
using Oicar.Service.Models;

namespace Oicar.Service.Interfaces
{
    public interface IUserCloudConfigurationService
    {
        List<CloudCombinationResultDTO> GetAll(int userId);
        object Save(CloudCombinationResultDTO cloudCombination);
    }
}
