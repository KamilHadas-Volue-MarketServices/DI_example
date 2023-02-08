using Microsoft.AspNetCore.Mvc;

namespace DI_sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICustomClass _customClass;
        private readonly IDummy _dummy;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            ICustomClass customClass, IDummy dummy)
        {
            _logger = logger;
            _customClass = customClass;
            _dummy = dummy;
        }

        [HttpGet("GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            Console.WriteLine("text");
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet( "GetGuid")]
        public object TestDi()
        {
            return new
            {
                CustomClass = _customClass.RandomGuid,
                Dummy = _dummy.Guid
            };
        }

    }
}