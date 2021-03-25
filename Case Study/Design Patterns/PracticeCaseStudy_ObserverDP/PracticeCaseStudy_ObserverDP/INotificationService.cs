namespace PracticeCaseStudy_ObserverDP
{
    public interface INotificationService
    {
        void AddSubscriber(INotificationObserver observer);
        void RemoveSubscriber(INotificationObserver observer);
        void NotifySubscribers();
    }


}
