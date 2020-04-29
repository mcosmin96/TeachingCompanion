using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using TeachingCompanion.WebAPI.Hubs;
using TeachingCompanion.WebAPI.Temp;

namespace TeachingCompanion.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartHubController : ControllerBase
    {
        private readonly IHubContext<ChartHub> _hub;

        public ChartHubController(IHubContext<ChartHub> hub)
        {
            _hub = hub;
        }

        public IActionResult Get()
        {
            var timerManager = new TimerManager(() => _hub.Clients.All.SendAsync("TransferChartData", DataManager.GetData()));

            return Ok();
        }
    }
}