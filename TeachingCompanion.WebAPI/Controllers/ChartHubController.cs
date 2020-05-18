using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using TeachingCompanion.WebAPI.Hubs;
using TeachingCompanion.WebAPI.Models;
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

        [HttpGet]
        [Route("{ms}")]
        public IActionResult Get(int ms)
        {
            //var timerManager = new TimerManager(() => _hub.Clients.All.SendAsync("TransferChartData", DataManager.GetData()));

            var chart = new List<ChartModel>()
            {
                new ChartModel() { Data = new List<int>() { 0 }, Label = "10-20" },
                new ChartModel() { Data = new List<int>() { 0 }, Label = "20-30" },
                new ChartModel() { Data = new List<int>() { 0 }, Label = "40-50" },
                new ChartModel() { Data = new List<int>() { 0 }, Label = "60-90" }
            };

            var r = new Random();
            var prefI = r.Next(0, 4);

            for (var i = 0; i < 500; i++)
            {
                _hub.Clients.All.SendAsync("TransferChartData", chart);

                chart[r.Next(0, 4)].Data[0]++;

                if (i % 5 == 0)
                    chart[prefI].Data[0]++;
                Thread.Sleep(ms);
            }

            return Ok();
        }
    }
}