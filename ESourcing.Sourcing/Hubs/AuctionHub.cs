﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace ESourcing.Sourcing.Hubs
{
    public class AuctionHub : Hub
    {
        public async Task AddToGroupAsync(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }
        public async Task SendBidAsync(string groupName, string user, string bid)
        {
            await Clients.Groups(groupName).SendAsync("Bids", user, bid);
        }
    }
}
