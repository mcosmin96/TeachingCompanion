using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachingCompanion.WebAPI.Models;

namespace TeachingCompanion.WebAPI.Hubs
{
    public class ChartHub : Hub
    {
        public async Task BroadcastChartData(List<ChartModel> data) =>
            await Clients.All.SendAsync("BroadcastChartData", data);
    }
}
