using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_handson
{
    public class MessagePublisher : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        private int getState = 1;
        public int GetState { get => getState; set => value = getState; }

        public void Attach(IObserver o)
        {

            observers.Add(o);

        }

        public void ChangeState(int val)
        {
            if (val != getState)
            {

                GetState = val;

                NotifyUpdate(new Message("Subject State has been changed"));
            }
        }

        public void Detach(IObserver o)
        {
            observers.Remove(o);
        }
        public void NotifyUpdate(Message m)
        {


            observers.ForEach(x => x.Update(m));
        }
    }
}
