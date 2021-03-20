using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class AdminObserver : INotificationObserver
    {
        public string EventName { get; set; }
        public int Tecket { get ; set; }

        public AdminObserver(string eventName,int tecket)
        {
            if(tecket >= 100)
            {
                this.Tecket = tecket;
                EventName = eventName;
            }
        }

        public void OnServerDown()
        {
            Console.WriteLine("Admin recived notification from "+EventName+" event with "+ Tecket + " teckets");
        }
    }
}
