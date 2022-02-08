using Microsoft.AspNetCore.Mvc;

namespace EasyApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Coolish", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching", "Muggy"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet("Forecast", Name = "GetWeatherForecast" )]
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

    [HttpGet("test/GetMockWeather", Name = "GetMockWeather")]
    public ActionResult<string> GetMockWeather()
    {
        var val = "24";
        return "Good";
    }
}
