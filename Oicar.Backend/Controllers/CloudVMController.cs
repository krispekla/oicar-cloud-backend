using System;
using Microsoft.AspNetCore.Mvc;
using Oicar.Service.Interfaces;

namespace Oicar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CloudVMController : ControllerBase
    {
        private readonly ICloudVMService _cloudVMService;

        public CloudVMController(ICloudVMService cloudVMService)
        {
            _cloudVMService = cloudVMService ?? throw new ArgumentNullException(nameof(cloudVMService));
        }
    }
}
