using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Microservice1.Controllers
{
    [ApiController]
    [Route("api")]
    public class TestController : ControllerBase
    {
        private static readonly string[] Data = new[]
        {
            "service1", "service1", "service1", "service1", "service1"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public TestController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("service1")]
        public ActionResult Get()
        {
            return Ok(Data);
        }
    }
}
