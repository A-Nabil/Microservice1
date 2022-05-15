using Microservice1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

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
        private IService2Service _service2Service;

        public TestController(ILogger<WeatherForecastController> logger, IService2Service service2Service)
        {
            _logger = logger;
            _service2Service = service2Service;
        }

        [HttpGet]
        [Route("service1")]
        public ActionResult Get()
        {
            return Ok(Data);
        }

        [HttpGet]
        [Route("service2")]
        public async Task<ActionResult> GetfromExternalAsync()
        {
            var data = await _service2Service.getValuesfromService2();
            return Ok(data);
        }
    }
}
