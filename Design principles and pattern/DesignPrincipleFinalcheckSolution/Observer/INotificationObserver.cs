using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface INotificationObserver
    {
        int Tecket { get; set; }
        string EventName { get; set; }
        void OnServerDown();
    }
}
