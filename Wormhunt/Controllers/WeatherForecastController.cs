using Microsoft.AspNetCore.Mvc;
using Wormhunt.Core.Models;
using Wormhunt.Core.Services;
using Wormhunt.Core.Services.Hunting;

namespace Wormhunt.Controllers
{
    [Route("[controller]")]
    public class WeatherForecastController : BaseController
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IHuntingService _huntingService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IHuntingService huntingService)
        {
            _logger = logger;
            _huntingService = huntingService;
        }

        /// <summary>
        /// Some docs <see cref="WeatherForecast"/>
        /// </summary>
        /// <response code="200">RETURN SHIT</response>
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var result = _huntingService.Hunt(MockDataProvider.GetHunter());

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = result,
            })
            .ToArray();
        }
    }
}