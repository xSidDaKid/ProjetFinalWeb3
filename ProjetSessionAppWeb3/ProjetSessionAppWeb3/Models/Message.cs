using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetSessionAppWeb3.Models
{
    public partial class Message
    {
        public int IdMessage { get; set; }
        public int IdChat { get; set; }
        public int IdUser { get; set; }
        public string Username { get; set; }
        public DateTime DateMessaged { get; set; }
        public string Description { get; set; }

        public virtual Chat IdChatReference {get;set;}
        public virtual User IdUserReference { get; set; }
    }
}
