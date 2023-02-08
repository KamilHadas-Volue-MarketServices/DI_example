using Components;
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
        private readonly IEventHandler _eventHandler;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            ICustomClass customClass, IDummy dummy, IEventHandler eventHandler)
        {
            _logger = logger;
            _customClass = customClass;
            _dummy = dummy;
            _eventHandler = eventHandler;
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
            _eventHandler.PublishEvent(new SimpleEvent{MessageToPass = ""});
            return new
            {
                CustomClass = _customClass.RandomGuid,
                Dummy = _dummy.Guid
            };
        }

    }
}