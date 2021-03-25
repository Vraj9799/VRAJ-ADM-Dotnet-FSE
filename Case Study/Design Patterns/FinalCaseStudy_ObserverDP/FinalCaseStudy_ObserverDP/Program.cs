using System;

namespace FinalCaseStudy_ObserverDP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            INotificationObserver observer = new AdminObserver("Vraj");
            INotificationObserver observer1 = new AdminObserver("Jerry");
            INotificationObserver observer2 = new AdminObserver("Tom");
            INotificationService service = new NotificationService();
            service.AddAdmin(observer);
            service.AddAdmin(observer1);
            service.AddAdmin(observer2);
            service.NotifyAdmin();
            service.RemoveAdmin(observer);
            service.NotifyAdmin();
            Console.Read();
        }
    }
}
