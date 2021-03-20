using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_handson
{
    public class Message

    {

        String messageContent;

        public Message(String m)
        {
            this.messageContent = m;
        }
        public String getMessageContent()
        {
            return messageContent;
        }
    }
}
