using System;
using Microsoft.AspNetCore.Mvc;
using Oicar.Service.Interfaces;
using System.Collections.Generic;
using Oicar.Dal.Entities;

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

        [HttpGet]
        public ActionResult<CloudVM> Get(int id)
        {
            return Ok(_cloudVMService.Get(id));
        }

        [HttpGet]
        [Route("getAll")]
        public ActionResult<List<CloudVM>> GetAll()
        {
            return Ok(_cloudVMService.GetAll());
        }

        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody] CloudVM cloudVM)
        {
            return Ok(_cloudVMService.Add(cloudVM));
        }

        [HttpPut]
        [Route("update")]
        public ActionResult Update([FromBody] CloudVM cloudVM)
        {
            return Ok(_cloudVMService.Update(cloudVM));
        }

        [HttpDelete]
        [Route("remove")]
        public ActionResult Remove([FromBody] CloudVM cloudVM)
        {
            return Ok(_cloudVMService.Remove(cloudVM));
        }
    }
}
