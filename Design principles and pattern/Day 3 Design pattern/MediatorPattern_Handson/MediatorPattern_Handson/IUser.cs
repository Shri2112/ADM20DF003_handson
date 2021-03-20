using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern_Handson
{
    interface IUser
    {
        void ReceiveMessage(string msg);
        void SendMessage(string msg);
    }
}
