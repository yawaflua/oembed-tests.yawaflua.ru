using Microsoft.AspNetCore.Mvc;

namespace OembedTests.Controllers
{
    [ApiController]
    [Route("pay")]
    public class WeatherForecastController : ControllerBase
    {
        
        [HttpGet("/{userName}")]
        public async Task<IActionResult> Get(string userName)
        {
            return Ok(userName);
        }
    }
}
