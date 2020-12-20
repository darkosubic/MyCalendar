using System;

namespace MyCalendar.Data.Models
{
    public class Absence
    {
        public Guid Id { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public Guid AbsenceTypeId { get; set; }

        public string UserId { get; set; }
    }
}
