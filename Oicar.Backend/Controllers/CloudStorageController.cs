using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Oicar.Dal.Entities;
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

        [HttpGet]
        public ActionResult<CloudStorage> Get(int id)
        {
            return Ok(_cloudStorageService.Get(id));
        }

        [HttpGet]
        [Route("getAll")]
        public ActionResult<List<CloudStorage>> GetAll()
        {
            return Ok(_cloudStorageService.GetAll());
        }

        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody] CloudStorage cloudStorage)
        {
            return Ok(_cloudStorageService.Add(cloudStorage));
        }

        [HttpPut]
        [Route("update")]
        public ActionResult Update([FromBody] CloudStorage cloudStorage)
        {
            return Ok(_cloudStorageService.Update(cloudStorage));
        }

        [HttpDelete]
        [Route("remove")]
        public ActionResult Remove([FromBody] CloudStorage cloudStorage)
        {
            return Ok(_cloudStorageService.Remove(cloudStorage));
        }
    }
}
