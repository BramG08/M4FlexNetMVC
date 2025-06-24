using Microsoft.AspNetCore.Mvc;
using huisdata.Models;

namespace huisdata.Controllers;

[ApiController]
[Route("[controller]")]
public class HuisController : ControllerBase
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

    [HttpGet()]
    public IEnumerable<EnergyVerbruik> Get()
    {
        return new List<EnergyVerbruik>() { new EnergyVerbruik() };
    }
    
}
