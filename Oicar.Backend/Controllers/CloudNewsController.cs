using System;
using Microsoft.AspNetCore.Mvc;
using Oicar.Service.Interfaces;

namespace Oicar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CloudNewsController : ControllerBase
    {
        private readonly ICloudNewsService _cloudNewsService;

        public CloudNewsController(ICloudNewsService cloudNewsService)
        {
            _cloudNewsService = cloudNewsService ?? throw new ArgumentNullException(nameof(cloudNewsService));
        }
    }
}
