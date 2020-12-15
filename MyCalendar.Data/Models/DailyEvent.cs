using System;

namespace MyCalendar.Data.Models
{
    public record DailyEvent
    {
        public DailyEvent(
            Guid id,
            Guid dailyEventTypeId,
            Guid userId,
            Guid eventOrderId,
            DateTime eventTime,
            string? title,
            string? description,
            Guid locationId,
            string? customLocation,
            bool isCanceled
            )
            => (Id, DailyEventTypeId, UserId, EventOrderId, EventTime, Title, Description, LocationId, CustomLocation, IsCanceled)
            = (id, dailyEventTypeId, userId, eventOrderId, eventTime, title, description, locationId, customLocation, isCanceled);
        

        public Guid Id { get; }

        public Guid DailyEventTypeId { get; }

        public Guid UserId { get; }

        public Guid EventOrderId { get; }

        public DateTime EventTime { get; }

        public string? Title { get; }

        public string? Description { get; }

        public Guid? LocationId { get; }

        public string? CustomLocation { get; }

        public bool IsCanceled { get; }
    }
}
