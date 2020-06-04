using Oicar.Dal;
using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;
using Oicar.Service.Interfaces;
using Oicar.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Oicar.Service.Services
{
    public class StatisticService : IStatisticService
    {
        private IUnitOfWork _uow;

        public StatisticService(OicarContext context)
        {
            _uow = new UnitOfWork(context);
        }

        public List<CloudCombinationDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<KeyValuePair<CloudDbSQL, int>> GetTopCloudDbSQL()
        {
            List<KeyValuePair<CloudDbSQL, int>> clouds = _uow.UserCloud.GetAllUserCloudDbSQL().GroupBy(y => y.Id).ToDictionary(z => z.First(), z => z.Count()).OrderByDescending(g => g.Value).ToList();
            return clouds;
        }

        public List<KeyValuePair<CloudFunction, int>> GetTopCloudFunction()
        {
            List<KeyValuePair<CloudFunction, int>> clouds = _uow.UserCloud.GetAllUserCloudFunctions().GroupBy(y => y.Id).ToDictionary(z => z.First(), z => z.Count()).OrderByDescending(g => g.Value).ToList();
            return clouds;
        }

        public List<KeyValuePair<CloudStorage, int>> GetTopCloudStorage()
        {
            List<KeyValuePair<CloudStorage, int>> clouds = _uow.UserCloud.GetAllUserCloudStorage().GroupBy(y => y.Id).ToDictionary(z => z.First(), z => z.Count()).OrderByDescending(g => g.Value).ToList();
            return clouds;
        }

        public List<KeyValuePair<CloudVM, int>> GetTopCloudVM()
        {
            List<KeyValuePair<CloudVM, int>> clouds = _uow.UserCloud.GetAllUserCloudVM().GroupBy(y => y.Id).ToDictionary(z => z.First(), z => z.Count()).OrderByDescending(g => g.Value).ToList();
            return clouds;
        }

        public List<CloudCombinationStatisticDTO> GetTopUserCombination()
        {
            List<CloudCombinationStatisticDTO> result = new List<CloudCombinationStatisticDTO>();
            List<KeyValuePair<CloudVM, int>> cloudVM = GetTopCloudVM();
            List<KeyValuePair<CloudDbSQL, int>> cloudDb = GetTopCloudDbSQL();
            List<KeyValuePair<CloudFunction, int>> cloudFunction = GetTopCloudFunction();
            List<KeyValuePair<CloudStorage, int>> cloudStorage = GetTopCloudStorage();

            List<Tuple<int, string>> orderingMostOccurances = new List<Tuple<int, string>>()
            {
            Tuple.Create( (int)cloudVM[0].Value, "cloudVM" ),
            Tuple.Create( (int)cloudDb[0].Value, "cloudDb" ),
            Tuple.Create( (int)cloudFunction[0].Value, "cloudFunction" ),
            Tuple.Create( (int)cloudStorage[0].Value, "cloudStorage" )
            };
            orderingMostOccurances.OrderBy(x => x.Item1);

            for (int i = 0; i < cloudStorage.Count; i++)
            {
                CloudCombinationStatisticDTO temp = new CloudCombinationStatisticDTO();
                temp.CloudVM = cloudVM[i].Key ?? null;
                temp.CloudStorage = cloudStorage[i].Key ?? null;
                temp.CloudFunction = cloudFunction[i].Key ?? null;
                temp.CloudDbSQL = cloudDb[i].Key ?? null;
                temp.TotalPrice = SumTotalPrice(cloudVM[i].Key, cloudStorage[i].Key, cloudFunction[i].Key, cloudDb[i].Key);
                temp.Date = cloudVM[i].Key.Created;
                temp.Provider = ((CloudProvider)cloudVM[i].Key.CloudProvider).ToString();
                temp.TotalCombinations = cloudVM[i].Value;
                result.Add(temp);
            }
            return result;
        }

        private double SumTotalPrice(CloudVM key1, CloudStorage key2, CloudFunction key3, CloudDbSQL key4)
        {
            double sum = 0;
            sum += key1 != null ? key1.Price : 0;
            sum += key2 != null ? key2.Price : 0;
            sum += key3 != null ? key3.Price : 0;
            sum += key4 != null ? key4.Price : 0;
            return sum;
        }
    }
}
