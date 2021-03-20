using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern_Handson
{
    class BasicUser : IUser
    {
        ChatMediator _chatMediator;
        string _name;

        public BasicUser(ChatMediator chatMediator, string name)
        {
            _name = name;
            _chatMediator = chatMediator;
        }

        public void ReceiveMessage(string msg)
        {
            Console.WriteLine(_name + " User get msg as " + msg);
        }

        public void SendMessage(string msg)
        {
            _chatMediator.SendMessage(msg + " By " + _name);
        }
    }
}
