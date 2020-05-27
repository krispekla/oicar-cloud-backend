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
            List <UserCloud> result = _uow.UserCloud.GetAllById(userId).ToList();
            foreach (UserCloud item in result)
            {
                CloudCombinationResultDTO temp = new CloudCombinationResultDTO();
                temp.CloudCombinationInput = JsonSerializer.Deserialize<CloudCombinationDTO>(item.UserInput);
                temp.CloudCombinationResult.CloudDbSQL = item.CloudDbSQL;
                temp.CloudCombinationResult.CloudFunction = item.CloudFunction;
                temp.CloudCombinationResult.CloudStorage = item.CloudStorage;
                temp.CloudCombinationResult.CloudVM = item.CloudVM;
                temp.UserId = item.User.Id;
                finalResult.Add(temp);
            }
            return finalResult;
        }

        public object Save(CloudCombinationResultDTO cloudCombination)
        {
            UserCloud userCloud = new UserCloud();
            userCloud.UserInput = JsonSerializer.Serialize(cloudCombination.CloudCombinationInput);
            userCloud.User = _uow.Users.Get(cloudCombination.UserId);
            userCloud.CloudDbSQL = cloudCombination.CloudCombinationResult.CloudDbSQL;
            userCloud.CloudFunction = cloudCombination.CloudCombinationResult.CloudFunction;
            userCloud.CloudStorage = cloudCombination.CloudCombinationResult.CloudStorage;
            userCloud.CloudVM = cloudCombination.CloudCombinationResult.CloudVM;
            userCloud.IsActive = true;

            _uow.UserCloud.Add(userCloud);
            _uow.Complete();
            return new { message = "Combination succesfully saved" };
        }
    }
}
