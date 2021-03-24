using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_SignalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task EnvoyerMessage(string username, string message)
        {
            await Clients.All.SendAsync("RecevoirMessage", username, message);
        }
    }
}
