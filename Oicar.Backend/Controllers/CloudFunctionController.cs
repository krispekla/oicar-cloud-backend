using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Oicar.Dal.Entities;
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

        [HttpGet]
        public ActionResult<CloudFunction> Get(int id)
        {
            return Ok(_cloudFunctionService.Get(id));
        }

        [HttpGet]
        [Route("getAll")]
        public ActionResult<List<CloudFunction>> GetAll()
        {
            return Ok(_cloudFunctionService.GetAll());
        }

        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody] CloudFunction cloudFunction)
        {
            return Ok(_cloudFunctionService.Add(cloudFunction));
        }

        [HttpPut]
        [Route("update")]
        public ActionResult Update([FromBody] CloudFunction cloudFunction)
        {
            return Ok(_cloudFunctionService.Update(cloudFunction));
        }

        [HttpDelete]
        [Route("remove")]
        public ActionResult Remove([FromBody] CloudFunction cloudFunction)
        {
            return Ok(_cloudFunctionService.Remove(cloudFunction));
        }

    }
}
