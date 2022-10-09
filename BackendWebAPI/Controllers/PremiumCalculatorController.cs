using BackendWebAPI.Models;
using BackendWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BackendWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PremiumCalculatorController : ControllerBase
    {
        private readonly ILogger<PremiumCalculatorController> _logger; 
        private readonly IPremiumService _premiumService;

        public PremiumCalculatorController(ILogger<PremiumCalculatorController> logger, IPremiumService premiumService)
        {
            _logger = logger;
            _premiumService = premiumService;
        }

        [HttpGet]
        [ActionName("CalculatePremium")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<double> CalculatePremium([FromQuery] int age, [FromQuery] double amount, [FromQuery] string occupation)
        {
            _logger.LogInformation("CalculatePremium method executing");
            PremiumDetail premiumDetail = new PremiumDetail
                {   
                    Age = age,
                    SumInsured = amount,
                    Occupation = occupation
                };
            PremiumResponse premiumResponse = new PremiumResponse();
            try
            {
                premiumResponse.MonthlyPremium = _premiumService.CalculatePremium(premiumDetail);
                _logger.LogInformation("CalculatePremium method executed");

                if (premiumResponse.MonthlyPremium >= 0)
                {
                    return Ok(premiumResponse.MonthlyPremium);
                }
                return BadRequest();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

    }
}