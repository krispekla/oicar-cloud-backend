using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Oicar.Dal.Entities;
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

        [HttpGet]
        public ActionResult<NewsPost> Get(int id)
        {
            return Ok(_cloudNewsService.Get(id));
        }

        [HttpGet]
        [Route("getAll")]
        public ActionResult<List<NewsPost>> GetAll()
        {
            return Ok(_cloudNewsService.GetAll());
        }

        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody] NewsPost newsPost)
        {
            return Ok(_cloudNewsService.Add(newsPost));
        }

        [HttpPut]
        [Route("update")]
        public ActionResult Update([FromBody] NewsPost newsPost)
        {
            return Ok(_cloudNewsService.Update(newsPost));
        }

        [HttpDelete]
        [Route("remove")]
        public ActionResult Remove([FromBody] NewsPost newsPost)
        {
            return Ok(_cloudNewsService.Remove(newsPost));
        }
    }
}
