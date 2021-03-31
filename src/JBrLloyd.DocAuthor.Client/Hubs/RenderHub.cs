using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace JBrLloyd.DocAuthor.Client.Hubs
{
    public class RenderHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
