using System;

namespace MyCalendar.Data.Models
{
    public record Holiday
    {
        public Holiday(Guid id, 
            string defaultName,
            int? dayStart,
            int? dayEnd,
            int? monthStart,
            int? monthEnd,
            bool hasYearSpecificDate,
            Guid countryId,
            DateTime? activeFrom,
            DateTime? activeTo, 
            DateTime? dateActiveOnly,
            bool isActive)
            => (Id, DefaultName, DayStart, DayEnd, MonthStart, MonthEnd, HasYearSpecificDate, CountryId, ActiveFrom, ActiveTo, DateActiveOnly, IsActive)
            =  (id, defaultName, dayStart, dayEnd, monthStart, monthEnd, hasYearSpecificDate, countryId, activeFrom, activeTo, dateActiveOnly, isActive);

        public Guid Id { get; }

        public string DefaultName { get; }

        public int? DayStart { get; }

        public int? DayEnd { get; }

        public int? MonthStart { get; }

        public int? MonthEnd { get; }

        public bool HasYearSpecificDate { get; }

        public Guid CountryId { get; }

        public DateTime? ActiveFrom { get; }

        public DateTime? ActiveTo { get; }

        public DateTime? DateActiveOnly { get; }

        public bool IsActive { get; }
    }
}
