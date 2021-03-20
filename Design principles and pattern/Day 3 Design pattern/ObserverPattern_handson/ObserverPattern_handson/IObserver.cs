using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_handson
{
    public interface IObserver
    {
        void Update(Message m);
    }
}
