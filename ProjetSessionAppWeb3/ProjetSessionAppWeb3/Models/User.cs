using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetSessionAppWeb3.Models
{
    public class User
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Email{ get; set; }
        public string Password{ get; set; }

        public virtual ICollection<Chat> Chats { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
