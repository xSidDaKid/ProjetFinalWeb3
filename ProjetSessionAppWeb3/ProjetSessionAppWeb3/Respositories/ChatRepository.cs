using Microsoft.EntityFrameworkCore;
using ProjetSessionAppWeb3.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetSessionAppWeb3.Respositories
{
    public class ChatRepository : IChatRepository
    {
        private readonly DataBaseContext _context;
        private int id;

        public ChatRepository(DataBaseContext context)
        {
            _context = context;
            if (_context.Chats.Count() > 0)
            {
                id = _context.Chats.AsEnumerable().Last().IdChat;
                _context.ChangeTracker.Clear();
            }
            else
            {
                id = 0;
            }
        }
        public async Task CreateChat(Chat c)
        {
            _context.Chats.Add(c);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteChat(int id)
        {
            var deleteChat = _context.Chats.Find(id);
            _context.Chats.Remove(deleteChat);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Chat>> GetAllChats()
        {
            return await _context.Chats.ToListAsync();
        }

        public async Task<IEnumerable<Chat>> GetAllChatsByName(string name)
        {
            return await _context.Chats.Where(c => c.ChatName.StartsWith(name)).ToListAsync();
        }
    }
}
