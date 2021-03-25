using System.Collections.Generic;

namespace PracticeCaseStudy_ObserverDP
{
    public class NotificationService : INotificationService
    {
        private List<INotificationObserver> _observers;
        public NotificationService()
        {
            _observers = new List<INotificationObserver>();
        }
        public void AddSubscriber(INotificationObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifySubscribers()
        {
            foreach (INotificationObserver item in _observers)
                item.OnServerDown();
        }

        public void RemoveSubscriber(INotificationObserver observer)
        {
            _observers.Remove(observer);
        }
    }


}
