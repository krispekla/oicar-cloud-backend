using System;
using Microsoft.AspNetCore.Mvc;
using Oicar.Service.Interfaces;

namespace Oicar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CloudFunctionController : ControllerBase
    {
        private readonly ICloudFunctionService _cloudFunctionService;

        public CloudFunctionController(ICloudFunctionService cloudFunctionService)
        {
            _cloudFunctionService = cloudFunctionService ?? throw new ArgumentNullException(nameof(cloudFunctionService));
        }
    }
}
