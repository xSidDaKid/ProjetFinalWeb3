using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetSessionAppWeb3.Models
{
    public class Chat
    {
        public int IdChat { get; set; }
        public string ChatName { get; set; }
        public int IdCreator { get; set; }

        public virtual User IdCreatorReference { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
