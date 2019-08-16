using System;
using Actio.Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace Actio.Api.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly IBusClient _busClient;

        public HomeController(IBusClient busClient)
        {
            _busClient = busClient;
        }

        [HttpGet("")]
        public async System.Threading.Tasks.Task<IActionResult> GetAAsync()
        {
            var command = new CreateActivity();
            command.Id = Guid.NewGuid();
            command.CreatedAt = DateTime.UtcNow;
            await _busClient.PublishAsync(command);

            return Accepted($"activities/{command.Id}");
        }
    }
}