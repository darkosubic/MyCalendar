using System;

namespace MyCalendar.Data.Models
{
    public class DailyEventParticipants
    {
        public Guid EventId { get; set; }
        
        public Guid UserId { get; set; }
    }
}
