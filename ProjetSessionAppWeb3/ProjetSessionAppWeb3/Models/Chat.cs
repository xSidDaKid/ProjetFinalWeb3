using System.Collections.Generic;

namespace ProjetSessionAppWeb3.Models
{
    public partial class Chat
    {
        public int IdChat { get; set; }
        public string ChatName { get; set; }
        public int IdCreator { get; set; }

        public virtual User IdCreatorReference { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<UserChat> UserChats { get; set; }
    }
}
