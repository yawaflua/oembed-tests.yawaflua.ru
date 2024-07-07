using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace OembedTests.Controllers
{
    [Route("/oembed")]
    [ApiController]
    public class OembedController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetOembed([FromQuery]string url, [FromQuery] string? format = "json")
        {
            // This is just example
            // TODO: rework this plz
            var userName = url.Replace("https://oembed-test.yawaflua.ru/pay/", "");
            var response = $@"{{
	""version"": ""1.0"",
	""type"": ""link"",
	""provider_name"": ""SP-Donate"",
	""provider_url"": ""https://sp-donate.ru/"",
	""title"": ""Donate to {userName} right now!"",
	""thumbnail_url"": ""https://avatar.spworlds.ru/front/240/{userName}""
	}}";
            return Ok(response);
        }
    }
}
