using System;

namespace MyCalendar.Data.Models
{
    public class DailyEvent
    {
        public Guid Id { get; set; }

        public Guid DailyEventTypeId { get; set; }

        public Guid UserId { get; set; }

        public Guid EventOrderId { get; set; }

        public DateTime EventTime { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public Guid? LocationId { get; set; }

        public string? CustomLocation { get; set; }

        public bool IsCanceled { get; set; }
    }
}
