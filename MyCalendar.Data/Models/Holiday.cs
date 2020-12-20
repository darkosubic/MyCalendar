using System;

namespace MyCalendar.Data.Models
{
    public class Holiday
    {
        public Guid Id { get; set; }

        public string DefaultName { get; set; }

        public int? DayStart { get; set; }

        public int? DayEnd { get; set; }

        public int? MonthStart { get; set; }

        public int? MonthEnd { get; set; }

        public bool HasYearSpecificDate { get; set; }

        public Guid CountryId { get; set; }

        public DateTime? ActiveFrom { get; set; }

        public DateTime? ActiveTo { get; set; }

        public DateTime? DateActiveOnly { get; set; }

        public bool IsActive { get; set; }
    }
}
