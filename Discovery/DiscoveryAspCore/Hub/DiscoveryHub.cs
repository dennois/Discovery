using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscoveryAspCore
{
    public class DiscoveryHub : Hub
    {
        public async Task SendAction(string user, int idAction)
        {
               await Clients.All.SendAsync("ReceiveAction", user, idAction);
        }
    }
}