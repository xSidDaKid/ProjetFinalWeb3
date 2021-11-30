﻿using ProjetSessionAppWeb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetSessionAppWeb3.Respositories
{
    public class UserChatRepository : IUserChatRepository
    {
        private readonly DataBaseContext _context;
        private int id;

        public async Task CreateUserChat(UserChat uc)
        {
            _context.UserChats.Add(uc);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserChat(UserChat uc)
        {
            _context.UserChats.Remove(uc);
            await _context.SaveChangesAsync();
        }
    }
}