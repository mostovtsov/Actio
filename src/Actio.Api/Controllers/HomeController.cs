using Microsoft.AspNetCore.Mvc;

namespace Actio.Api.Controllers
{
    [Route("")]
    public class HomeController: Controller
    {
        [HttpGet("")]
        public IActionResult GetA()=> Content("Hello from Actio API!");
    }
}