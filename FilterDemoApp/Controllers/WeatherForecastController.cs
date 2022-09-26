using Microsoft.AspNetCore.Mvc;

namespace FilterDemoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]

    // This is at the controller level filter which gives us the name of the
    // controller classes which class is being executed in order with there name.
    [MyActionFilter("User")]
    public class UserController : ControllerBase
    {
        public string Get()
        {
            return "Inside User Conteroller";
        }
    }


    [ApiController]
    [Route("[controller]")]

    // This is at the controller level filter which gives us the name of the
    // controller classes which class is being executed in order with there name.
   
    [MyActionFilter("controller")]

    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}