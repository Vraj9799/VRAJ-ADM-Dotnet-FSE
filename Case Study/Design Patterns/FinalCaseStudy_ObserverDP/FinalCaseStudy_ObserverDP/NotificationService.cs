using System;
using System.Collections.Generic;

namespace FinalCaseStudy_ObserverDP
{
    public class NotificationService : INotificationService
    {
        private List<INotificationObserver> _observers;

        public NotificationService()
        {
            _observers = new List<INotificationObserver>();
        }

        private List<Event> _events = new List<Event>()
        {
            new Event(1,"External Training",101),
            new Event(2,"SME",20),
            new Event(3,"Webinar on ReactJS",250)
        };
        public void AddAdmin(INotificationObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine($"{observer.Name} is Subscribed");
        }
        public void RemoveAdmin(INotificationObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine($"{observer.Name} is UnSubscribed");
        }
        public void NotifyAdmin()
        {
            foreach (INotificationObserver item in _observers)
                item.Update(_events);
        }


    }
}
