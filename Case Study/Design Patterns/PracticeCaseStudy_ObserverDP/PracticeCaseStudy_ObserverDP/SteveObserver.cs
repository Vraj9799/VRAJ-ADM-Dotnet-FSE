using System;

namespace PracticeCaseStudy_ObserverDP
{
    public class SteveObserver : INotificationObserver
    {
        public string Name { get; set; }

        public SteveObserver(string name)
        {
            Name = name;
        }

        public void OnServerDown()
        {
            Console.WriteLine($"Notification has been received by: {Name}");
        }
    }


}
