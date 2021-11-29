using ProjetSessionAppWeb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetSessionAppWeb3.Respositories
{
    interface IUserChatRepository
    {
        Task CreateUserChat(UserChat uc);
        Task DeleteUserChat(UserChat uc);
    }
}
