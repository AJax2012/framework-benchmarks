using Microsoft.AspNetCore.Mvc;

namespace DotnetBenchmark.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class HomeController : ControllerBase
  {
      [HttpGet]
      public IActionResult Get()
      {
        return Ok("Hello Dotnet");
      }
  }
}
