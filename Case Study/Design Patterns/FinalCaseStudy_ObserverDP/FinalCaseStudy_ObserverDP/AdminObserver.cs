using System;
using System.Collections.Generic;

namespace FinalCaseStudy_ObserverDP
{
    public class AdminObserver : INotificationObserver
    {
        public string Name { get; set; }

        public AdminObserver(string name)
        {
            Name = name;
        }

        public void Update(List<Event> events)
        {
            Console.WriteLine($"{Name} Received Notification of events");
            foreach (var item in events)
            {
                if (item.Tickets > 100)
                    Console.WriteLine($"Event Id = {item.EventId}, Tickets = {item.Tickets}, EventName = {item.EventName}");
            }
            Console.WriteLine();
        }
    }
}
