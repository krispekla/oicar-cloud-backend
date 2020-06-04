using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oicar.Dal.Entities;
using Oicar.Service.Interfaces;
using Oicar.Service.Models;

namespace Oicar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticController : ControllerBase
    {
        private readonly IStatisticService _statisticService;

        public StatisticController(IStatisticService statisticService)
        {
            _statisticService = statisticService ?? throw new ArgumentNullException(nameof(statisticService));
        }

        [HttpGet]
        [Route("cloudFunction")]
        public ActionResult<List<KeyValuePair<CloudFunction, int>>> GetCloudFunction()
        {
            List<KeyValuePair<CloudFunction, int>> result = _statisticService.GetTopCloudFunction();
            return Ok(result);
        }

        [HttpGet]
        [Route("cloudStorage")]
        public ActionResult<List<KeyValuePair<CloudStorage, int>>> GetCloudStorage()
        {
            List<KeyValuePair<CloudStorage, int>> result = _statisticService.GetTopCloudStorage();
            return Ok(result);
        }

        [HttpGet]
        [Route("cloudVM")]
        public ActionResult<List<KeyValuePair<CloudVM, int>>> GetCloudVM()
        {
            List<KeyValuePair<CloudVM, int>> result = _statisticService.GetTopCloudVM();
            return Ok(result);
        }

        [HttpGet]
        [Route("cloudDb")]
        public ActionResult<List<KeyValuePair<CloudDbSQL, int>>> GetCloudDb()
        {
            List<KeyValuePair<CloudDbSQL, int>> result = _statisticService.GetTopCloudDbSQL();
            return Ok(result);
        }

        [HttpGet]
        [Route("topCombination")]
        public ActionResult<List<CloudCombinationStatisticDTO>> GetTopCombinations()
        {
            List<CloudCombinationStatisticDTO> result = _statisticService.GetTopUserCombination();
            return Ok(result);
        }


    }
}