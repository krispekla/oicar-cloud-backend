using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Oicar.Dal;
using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;
using Oicar.Service.Interfaces;
using Oicar.Service.Models;

namespace Oicar.Service.Services
{
    public class UserCloudConfigurationService : IUserCloudConfigurationService
    {
        private IUnitOfWork _uow;

        public UserCloudConfigurationService(OicarContext context)
        {
            _uow = new UnitOfWork(context);
        }

        public List<CloudCombinationResultDTO> GetAll(int userId)
        {
            List<CloudCombinationResultDTO> finalResult = new List<CloudCombinationResultDTO>();
            List<UserCloud> result = _uow.UserCloud.GetAllById(userId).ToList();
            foreach (UserCloud item in result)
            {
                CloudCombinationResultDTO temp = new CloudCombinationResultDTO();
                CloudCombinationDTO cloudCombinationInput = new CloudCombinationDTO();
                CloudCombinationDTO cloudCombinationResult = new CloudCombinationDTO();

                cloudCombinationInput = JsonSerializer.Deserialize<CloudCombinationDTO>(item.UserInput);
                if (item.CloudDbSQL != null)
                cloudCombinationResult.CloudDbSQL = item.CloudDbSQL;
                if (item.CloudFunction != null)
                    cloudCombinationResult.CloudFunction = item.CloudFunction;
                if (item.CloudStorage != null)
                    cloudCombinationResult.CloudStorage = item.CloudStorage;
                if (item.CloudVM != null)
                    cloudCombinationResult.CloudVM = item.CloudVM;

                temp.CloudCombinationInput = cloudCombinationInput;
                temp.CloudCombinationResult = cloudCombinationResult;
                temp.UserId = userId;
                temp.Name = item.Name;
                temp.Id = item.Id;
                finalResult.Add(temp);
            }
            return finalResult;
        }

        public object Save(CloudCombinationResultDTO cloudCombination)
        {
            UserCloud userCloud = new UserCloud();
            userCloud.UserInput = JsonSerializer.Serialize(cloudCombination.CloudCombinationInput);
            userCloud.User = _uow.Users.Get(cloudCombination.UserId);
            userCloud.CloudDbSQL = cloudCombination.CloudCombinationResult.CloudDbSQL != null ? _uow.CloudDbSQL.Get(cloudCombination.CloudCombinationResult.CloudDbSQL.Id) : null;
            userCloud.CloudFunction = cloudCombination.CloudCombinationResult.CloudFunction != null ? _uow.CloudFunction.Get(cloudCombination.CloudCombinationResult.CloudFunction.Id) : null;
            userCloud.CloudStorage = cloudCombination.CloudCombinationResult.CloudStorage != null ? _uow.CloudStorage.Get(cloudCombination.CloudCombinationResult.CloudStorage.Id) : null;
            userCloud.CloudVM = cloudCombination.CloudCombinationResult.CloudVM != null ? _uow.CloudVM.Get(cloudCombination.CloudCombinationResult.CloudVM.Id) : null;
            userCloud.IsActive = true;
            userCloud.Name = cloudCombination.Name;

            _uow.UserCloud.Add(userCloud);
            _uow.Complete();
            return new { message = "Combination succesfully saved" };
        }
    }
}
