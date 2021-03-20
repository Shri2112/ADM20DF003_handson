using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_handson
{
    interface ISubject
    {
        int GetState { get; set; }

        void ChangeState(int val);
        void Attach(IObserver o);

        void Detach(IObserver o);
    }
}
