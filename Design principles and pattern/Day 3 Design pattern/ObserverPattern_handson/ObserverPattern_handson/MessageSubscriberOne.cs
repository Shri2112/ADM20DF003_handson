using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_handson
{
    public class MessageSubscriberOne : IObserver

    {



        public void Update(Message m)
        {

            Console.WriteLine("MessageSubscriberOne : " + m.getMessageContent());

        }

    }


    public class MessageSubscriberTwo : IObserver

    {



        public void Update(Message m)
        {

            Console.WriteLine("MessageSubscriberTwo : " + m.getMessageContent());

        }

    }


    public class MessageSubscriberThree : IObserver

    {



        public void Update(Message m)
        {

            Console.WriteLine("MessageSubscriberThree : " + m.getMessageContent());

        }

    }
}
