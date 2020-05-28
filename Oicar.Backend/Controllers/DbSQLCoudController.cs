using System;
using Microsoft.AspNetCore.Mvc;
using Oicar.Service.Interfaces;
using System.Collections.Generic;
using Oicar.Dal.Entities;

namespace Oicar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbSQLCoudController : ControllerBase
    {
        private readonly IDbSQLService _dbSQLService;

        public DbSQLCoudController(IDbSQLService dbSQLService)
        {
            _dbSQLService = dbSQLService ?? throw new ArgumentNullException(nameof(dbSQLService));
        }

        [HttpGet]
        public ActionResult<CloudDbSQL> Get(int id)
        {
            return Ok(_dbSQLService.Get(id));
        }

        [HttpGet]
        [Route("getAll")]
        public ActionResult<List<CloudDbSQL>> GetAll()
        {
            return Ok(_dbSQLService.GetAll());
        }

        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody] CloudDbSQL cloudDbSQL)
        {
            return Ok(_dbSQLService.Add(cloudDbSQL));
        }

        [HttpPut]
        [Route("update")]
        public ActionResult Update([FromBody] CloudDbSQL cloudDbSQL)
        {
            return Ok(_dbSQLService.Update(cloudDbSQL));
        }

        [HttpDelete]
        [Route("remove")]
        public ActionResult Remove([FromBody] CloudDbSQL cloudDbSQL)
        {
            return Ok(_dbSQLService.Remove(cloudDbSQL));
        }
    }
}
