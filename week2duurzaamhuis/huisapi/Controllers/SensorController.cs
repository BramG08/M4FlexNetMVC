using Microsoft.AspNetCore.Mvc;
using huisapi.Models;

namespace huisapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SensorController : ControllerBase
    {
        private readonly ILogger<SensorController> _logger;

        public SensorController(ILogger<SensorController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSensoren")]
        public Sensor Get()
        {
            Sensor sensor = new Sensor();
            sensor.ldr = 100;
            sensor.dht = new DHT();
            sensor.dht.Temperature = 25;
            sensor.dht.Humidity = 50;
            sensor.dht.heatIndex = 30;
            DHT dht = new DHT();
            return sensor;
        }
    }
}