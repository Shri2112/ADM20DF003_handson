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
            INotificationObserver steveObserver = new SteveObserver();
            steveObserver.Name = "Santosh";
            INotificationObserver johnObserver = new JohnObserver();
            johnObserver.Name = "Vinay";
            NotificationService notificationService = new NotificationService();
            notificationService.AddSubscriber(steveObserver);
            notificationService.AddSubscriber(johnObserver);
            notificationService.NotifySubscriber();
            notificationService.RemoveSubscriber(steveObserver);

            Console.ReadKey();

        }
    }
}
