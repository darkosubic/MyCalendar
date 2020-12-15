using System;

namespace MyCalendar.Data.Models
{
    public record DailyEventParticipants
    {
        public DailyEventParticipants(Guid eventId, Guid userId)
            => (EventId, UserId) = (eventId, userId);

        public Guid EventId { get; }
        
        public Guid UserId { get; }
    }
}
