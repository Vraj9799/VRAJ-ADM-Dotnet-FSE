using System.Collections.Generic;

namespace FinalCaseStudy_ObserverDP
{
    public interface INotificationObserver
    {
        public string Name { get; set; }
        public void Update(List<Event> events);
    }
}
