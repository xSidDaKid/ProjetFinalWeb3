using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ProjetSessionAppWeb3.Hubs
{
    public class ChatHub : Hub
    {
        /*  public void Send(string name, string message)
          {
              // Call the addNewMessageToPage method to update clients.
              Clients.All.addNewMessageToPage(name, message);

          }*/

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
