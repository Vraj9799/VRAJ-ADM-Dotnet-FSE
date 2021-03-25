using System;

namespace PracticeCaseStudy_ObserverDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            INotificationObserver steve = new SteveObserver("Steve");
            INotificationObserver john = new JohnObserver("John");
            INotificationService service = new NotificationService();
            service.AddSubscriber(john);
            service.AddSubscriber(steve);
            service.NotifySubscribers();
            service.RemoveSubscriber(steve);
            service.NotifySubscribers();
            Console.ReadLine();
        }
    }
}
