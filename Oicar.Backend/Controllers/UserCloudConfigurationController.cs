using System;
using Microsoft.AspNetCore.Mvc;
using Oicar.Dal.Entities;
using Oicar.Service.Interfaces;
using Oicar.Service.Models;
using Oicar.Service.Services;

namespace Oicar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCloudConfigurationController : ControllerBase
    {
        private readonly IUserCloudConfigurationService _userCloudConfigurationService;

        public UserCloudConfigurationController(IUserCloudConfigurationService userService)
        {
            _userCloudConfigurationService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        [HttpPost]
        [Route("save")]
        public ActionResult Save([FromBody] CloudCombinationResultDTO cloudComb)
        {
            return Ok(_userCloudConfigurationService.Save(cloudComb));
        }

        [HttpGet]
        [Route("getAll")]
        public ActionResult<CloudCombinationResultDTO> GetAll([FromQuery]int id)
        {
            return Ok(_userCloudConfigurationService.GetAll(id));
        }
    }
}
