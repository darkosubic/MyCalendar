using System;

namespace MyCalendar.Data.Models
{
    public record DailyEventType
    {
        public DailyEventType(Guid id, string defaultName) 
            => (Id, DefaultName) = (id, defaultName);
        
        public Guid Id { get; }
        
        public string DefaultName { get; }
    }
}
