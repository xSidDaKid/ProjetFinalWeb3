using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetSessionAppWeb3.Models
{
    public partial class UserChat
    {
        public int IdUser { get; set; }
        public int IdChat { get; set; }

        public virtual User IdUserReference { get; set; }
        public virtual Chat IdChatReference { get; set; }
    }
}
