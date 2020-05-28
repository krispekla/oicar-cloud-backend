using System;
using Microsoft.AspNetCore.Mvc;
using Oicar.Service.Interfaces;

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
    }
}
