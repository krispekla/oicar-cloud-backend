using Oicar.Dal.Entities;
using Oicar.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oicar.Service.Interfaces
{
    public interface IStatisticService
    {
        List<CloudCombinationStatisticDTO> GetTopUserCombination();
        List<KeyValuePair<CloudStorage, int>> GetTopCloudStorage();
        List<KeyValuePair<CloudFunction, int>> GetTopCloudFunction();
        List<KeyValuePair<CloudVM, int>> GetTopCloudVM();
        List<KeyValuePair<CloudDbSQL, int>> GetTopCloudDbSQL();
    }
}
