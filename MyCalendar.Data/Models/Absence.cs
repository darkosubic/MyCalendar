using System;

namespace MyCalendar.Data.Models
{
    public record Absence
    {
        public Absence(Guid id, 
            DateTime dateFrom, 
            DateTime dateTo, 
            Guid absenceTypeId, 
            string userId)
            => (Id, DateFrom, DateTo, AbsenceTypeId, UserId)
            = (id, dateFrom, dateTo, absenceTypeId, userId);

        public Guid Id { get; }

        public DateTime DateFrom { get; }

        public DateTime? DateTo { get; }

        public Guid AbsenceTypeId { get; }

        public string UserId { get; }
    }
}
