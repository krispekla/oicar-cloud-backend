using System;
using Microsoft.AspNetCore.Mvc;
using Oicar.Service.Interfaces;

namespace Oicar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CloudStorageController : ControllerBase
    {
        private readonly ICloudStorageService _cloudStorageService;

        public CloudStorageController(ICloudStorageService cloudStorageService)
        {
            _cloudStorageService = cloudStorageService ?? throw new ArgumentNullException(nameof(cloudStorageService));
        }
    }
}
