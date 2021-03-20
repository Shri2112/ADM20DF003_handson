using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern_Handson
{
    interface IChatMediator
    {
        void AddUser(IUser user);
        void SendMessage(string msg);
    }
}
