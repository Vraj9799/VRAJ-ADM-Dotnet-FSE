namespace PracticeCaseStudy_ObserverDP
{
    public interface INotificationObserver
    {
        public string Name { get; set; }
        public void OnServerDown();
    }


}
