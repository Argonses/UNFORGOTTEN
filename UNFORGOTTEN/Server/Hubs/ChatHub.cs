using Microsoft.AspNetCore.SignalR;

namespace UNFORGOTTEN.Server.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IHubContext<ChatHub> _hubContext;

        public ChatHub(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task AddMessageToChat(string user, string message)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
