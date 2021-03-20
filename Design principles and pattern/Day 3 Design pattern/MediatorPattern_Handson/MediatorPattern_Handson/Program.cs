using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern_Handson
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMediator chatMediator = new ChatMediator();
            IUser u1 = new BasicUser(chatMediator, "A");
            IUser u2 = new PremiumUser(chatMediator, "B");
            chatMediator.AddUser(u1);
            chatMediator.AddUser(u2);

            IUser u3 = new BasicUser(chatMediator, "C");
            u3.SendMessage("Hello");
            Console.ReadKey();
        }
    }
}
