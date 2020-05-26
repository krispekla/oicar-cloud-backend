using Oicar.Dal;
using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;
using Oicar.Service.Interfaces;
using Oicar.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Oicar.Service.Services
{
    public class CalculatorService : ICalculatorService
    {
        private IUnitOfWork _uow;

        public CalculatorService(OicarContext context)
        {
            _uow = new UnitOfWork(context);
        }

        public CloudCombinationResultDTO Calculate(CloudCombinationDTO cloudCombinationDTO)
        {
            IEnumerable<CloudFunction> cheapestCloudFunctions = _uow.CloudFunction.GetCheapestCloud(cloudCombinationDTO.CloudFunction);
            IEnumerable<CloudStorage> cheapestCloudStorage = _uow.CloudStorage.GetCheapestCloud(cloudCombinationDTO.CloudStorage);

            CloudCombinationResultDTO finalResult = new CloudCombinationResultDTO();

            finalResult.CloudCombinationInput = cloudCombinationDTO;
            finalResult.CloudCombinationResult = CalculateCheapestByComparingAllPrices(cheapestCloudFunctions, cheapestCloudStorage);

            return finalResult;
        }

        private CloudCombinationDTO CalculateCheapestByComparingAllPrices(IEnumerable<CloudFunction> cheapestCloudFunctions, IEnumerable<CloudStorage> cheapestCloudStorage)
        {
            List<CloudProvider> cloudProvider = Enum.GetValues(typeof(CloudProvider)).Cast<CloudProvider>().ToList();
            Dictionary<CloudProvider, double> providerWithTotalPrice = new Dictionary<CloudProvider, double>();
            foreach (CloudProvider providerEnum in cloudProvider)
            {
                providerWithTotalPrice.Add(providerEnum, SumAllPrices(providerEnum, cheapestCloudFunctions, cheapestCloudStorage));
            }

            providerWithTotalPrice.OrderBy(key => key.Value);

            CloudProvider cheapestCloudProvider = providerWithTotalPrice.First().Key;

            CloudCombinationDTO cheapestCombination = new CloudCombinationDTO();
            cheapestCombination.CloudFunction = cheapestCloudFunctions.Where(x => x.CloudProvider.Equals(cheapestCloudProvider)).First();
            cheapestCombination.CloudStorage = cheapestCloudStorage.Where(x => x.CloudProvider.Equals(cheapestCloudProvider)).First();
            return cheapestCombination;
        }

        private double SumAllPrices(CloudProvider providerEnum, IEnumerable<CloudFunction> cheapestCloudFunctions, IEnumerable<CloudStorage> cheapestCloudStorage)
        {
            double sum = 0;
            sum += cheapestCloudFunctions.Where(x => x.CloudProvider.Equals(providerEnum)).FirstOrDefault().Price;
            sum += cheapestCloudStorage.Where(x => x.CloudProvider.Equals(providerEnum)).FirstOrDefault().Price;
            return sum;
        }
    }
}
