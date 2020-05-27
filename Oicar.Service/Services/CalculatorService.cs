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
            List<CloudFunction> cheapestCloudFunctions = cloudCombinationDTO.CloudFunction != null ? _uow.CloudFunction.GetCheapestCloud(cloudCombinationDTO.CloudFunction) : null;
            List<CloudStorage> cheapestCloudStorage = cloudCombinationDTO.CloudStorage != null ? _uow.CloudStorage.GetCheapestCloud(cloudCombinationDTO.CloudStorage) : null;
            List<CloudDbSQL> cheapestCloudDbSQL = cloudCombinationDTO.CloudDbSQL != null ? _uow.CloudDbSQL.GetCheapestCloud(cloudCombinationDTO.CloudDbSQL) : null;
            List<CloudVM> cheapestCloudVM = cloudCombinationDTO.CloudVM != null ? _uow.CloudVM.GetCheapestCloud(cloudCombinationDTO.CloudVM) : null;

            CloudCombinationResultDTO finalResult = new CloudCombinationResultDTO();

            finalResult.CloudCombinationInput = cloudCombinationDTO;
            finalResult.CloudCombinationResult = CalculateCheapestByComparingAllPrices(cheapestCloudFunctions, cheapestCloudStorage, cheapestCloudDbSQL, cheapestCloudVM);
            
            return finalResult;
        }

        private CloudCombinationDTO CalculateCheapestByComparingAllPrices(List<CloudFunction> cheapestCloudFunctions, List<CloudStorage> cheapestCloudStorage, List<CloudDbSQL> cheapestCloudDbSQL, List<CloudVM> cheapestCloudVM)
        {
            List<CloudProvider> cloudProvider = Enum.GetValues(typeof(CloudProvider)).Cast<CloudProvider>().ToList();
            Dictionary<CloudProvider, double> providerWithTotalPrice = new Dictionary<CloudProvider, double>();
            foreach (CloudProvider providerEnum in cloudProvider)
            {
                providerWithTotalPrice.Add(providerEnum, SumAllPrices(providerEnum, cheapestCloudFunctions, cheapestCloudStorage, cheapestCloudDbSQL, cheapestCloudVM));
            }

            providerWithTotalPrice.OrderBy(key => key.Value);

            CloudProvider cheapestCloudProvider = providerWithTotalPrice.First().Key;

            CloudCombinationDTO cheapestCombination = new CloudCombinationDTO();
            cheapestCombination.CloudFunction = cheapestCloudFunctions?.Where(x => x.CloudProvider.Equals(cheapestCloudProvider)).First();
            cheapestCombination.CloudStorage = cheapestCloudStorage?.Where(x => x.CloudProvider.Equals(cheapestCloudProvider)).First();
            cheapestCombination.CloudDbSQL = cheapestCloudDbSQL?.Where(x => x.CloudProvider.Equals(cheapestCloudProvider)).First();
            cheapestCombination.CloudVM = cheapestCloudVM?.Where(x => x.CloudProvider.Equals(cheapestCloudProvider)).First();
            return cheapestCombination;
        }

        private double SumAllPrices(CloudProvider providerEnum, List<CloudFunction> cheapestCloudFunctions, List<CloudStorage> cheapestCloudStorage, List<CloudDbSQL> cheapestCloudDbSQL, List<CloudVM> cheapestCloudVM)
        {
            double sum = 0;
            sum += cheapestCloudFunctions != null ? cheapestCloudFunctions.Where(x => x.CloudProvider.Equals(providerEnum)).FirstOrDefault().Price : 0;
            sum += cheapestCloudStorage != null ? cheapestCloudStorage.Where(x => x.CloudProvider.Equals(providerEnum)).FirstOrDefault().Price : 0;
            sum += cheapestCloudDbSQL != null ? cheapestCloudDbSQL.Where(x => x.CloudProvider.Equals(providerEnum)).FirstOrDefault().Price : 0;
            sum += cheapestCloudVM != null ? cheapestCloudVM.Where(x => x.CloudProvider.Equals(providerEnum)).FirstOrDefault().Price : 0;
            return sum;
        }
    }
}
