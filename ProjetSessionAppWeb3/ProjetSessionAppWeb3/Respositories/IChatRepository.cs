using ProjetSessionAppWeb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetSessionAppWeb3.Respositories
{
    interface IChatRepository
    {
        Task<IEnumerable<Chat>> GetAllChats();
        Task <IEnumerable<Chat>> GetAllChatsByName(string name);
        Task CreateChat(Chat c);
        Task DeleteChat(int id);
    }
}
