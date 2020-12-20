using System;

namespace MyCalendar.Data.Models
{
    public class AbsenceType
    {
        public Guid Id { get; set; }

        public string DefaultName { get; set; }

        public bool IsPaid { get; set; }
    }
}
