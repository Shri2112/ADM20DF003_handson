using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern_Handson
{
    class ChatMediator : IChatMediator
    {
        List<IUser> users = new List<IUser>();

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string msg)
        {
            foreach (IUser u in users)
            {
                u.ReceiveMessage(msg);
            }
        }
    }
}
