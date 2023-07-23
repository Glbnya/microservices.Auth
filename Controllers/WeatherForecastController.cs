using AuthMicroservice.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuthMicroservice.Controllers
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

        [HttpPost]
        [Route("login")]
        public string Login([FromBody] LoginRequest loginRequest )
        {
            //if (loginRequest.Login != null && loginRequest.Password != null)
                return "123";
        }
    }
}