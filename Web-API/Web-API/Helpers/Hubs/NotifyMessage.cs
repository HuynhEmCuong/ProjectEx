using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Dtos;
using Web_API.Models;
using Web_API.Service.Interface;

namespace Web_API.Helpers.Hubs
{
    public class NotifyMessage : Hub
    {
        private readonly IPDCService _pdcService;
        public NotifyMessage(IPDCService pdcService)
        {
            _pdcService = pdcService;
        }


        public override  async Task OnConnectedAsync()
        {
            var data = await GetListPDC();
            await Clients.All.SendAsync("PDCData", data);
        }

        public async Task<List<PDCDto>> GetListPDC()
        {
            return await _pdcService.GetALL();
        }
        public async Task NotifyLoad(string message)
        {
            await Clients.All.SendAsync("NotifyLoad", message);
        }

      
    }
}
