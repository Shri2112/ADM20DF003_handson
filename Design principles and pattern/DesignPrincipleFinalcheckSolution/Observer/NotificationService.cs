using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class NotificationService : INotificationService
    {
        List<INotificationObserver> notificationObserverList = new List<INotificationObserver>();

        public void AddSubscriber(INotificationObserver notificationObserver)
        {
            if (notificationObserver.Tecket >= 100)
            {
                notificationObserverList.Add(notificationObserver);
                Console.WriteLine("\nList of Events Subscribed");
                foreach (var list in notificationObserverList)
                {
                    Console.WriteLine(list.EventName);
                }
            }
        }

        public void NotifySubscriber()
        {
            foreach (var list in notificationObserverList)
            {
                list.OnServerDown();
            }
        }

        public void RemoveSubscriber(INotificationObserver notificationObserver)
        {
            notificationObserverList.Remove(notificationObserver);
            Console.WriteLine("\nList of Events Subscribed");
            foreach (var list in notificationObserverList)
            {
                Console.WriteLine(list.EventName);
            }
        }
    }
}
