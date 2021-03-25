using System;

namespace PracticeCaseStudy_ObserverDP
{
    public class JohnObserver : INotificationObserver
    {
        public string Name { get; set; }

        public JohnObserver(string name)
        {
            Name = name;
        }

        public void OnServerDown()
        {
            Console.WriteLine($"Notification has been received by: {Name}");
        }
    }


}
