using System;

namespace MyCalendar.Data.Models
{
    public record AbsenceType
    {
        public AbsenceType(Guid id, string defaultName, bool isPaid)
            => (Id, DefaultName, IsPaid) = (id, defaultName, isPaid);

        public Guid Id { get;  }

        public string DefaultName { get; }

        public bool IsPaid { get; }
    }
}
