using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificationObserver adminObserver1 = new AdminObserver("New Year",150);
            INotificationObserver adminObserver2 = new AdminObserver("Christmas",110);
            INotificationObserver adminObserver3 = new AdminObserver("Christmas Eve",90);

            NotificationService notificationService = new NotificationService();

            notificationService.AddSubscriber(adminObserver1);
            notificationService.AddSubscriber(adminObserver2);
            notificationService.AddSubscriber(adminObserver3);
            notificationService.NotifySubscriber();

            notificationService.RemoveSubscriber(adminObserver2);

            Console.ReadKey();

        }
    }
}
