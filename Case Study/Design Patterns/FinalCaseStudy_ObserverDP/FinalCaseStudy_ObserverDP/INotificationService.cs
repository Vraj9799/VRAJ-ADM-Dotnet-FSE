namespace FinalCaseStudy_ObserverDP
{
    public interface INotificationService
    {
        void AddAdmin(INotificationObserver observer);
        void RemoveAdmin(INotificationObserver observer);
        void NotifyAdmin();
    }
}
