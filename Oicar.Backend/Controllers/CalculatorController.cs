using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Oicar.Service.Interfaces;
using Oicar.Service.Models;

namespace Oicar.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService ?? throw new ArgumentNullException(nameof(calculatorService));
        }

        [HttpPost]
        public ActionResult<CloudCombinationResultDTO> Calculate([FromBody]CloudCombinationDTO cloudCombination)
        {
            return _calculatorService.Calculate(cloudCombination);
        }
    }
}