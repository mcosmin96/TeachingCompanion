using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeachingCompanion.WebAPI.Hubs
{
    public class QuestionHub : Hub
    {
        public async Task SendMessage(string name, string question)
        {
            await Clients.All.SendAsync("ReceiveQuestion", name, question);
        }
    }
}
