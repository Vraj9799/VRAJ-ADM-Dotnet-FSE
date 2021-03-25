namespace FinalCaseStudy_ObserverDP
{
    public class Event
    {
        public Event(int eventId, string eventName, int tickets)
        {
            EventId = eventId;
            EventName = eventName;
            Tickets = tickets;
        }

        public int EventId { get; set; }
        public string EventName { get; set; }
        public int Tickets { get; set; }
    }


}
