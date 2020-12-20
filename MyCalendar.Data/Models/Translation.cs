using System;

namespace MyCalendar.Data.Models
{
    public class Translation
    {
        Guid Id { get; set; }

        Guid CountryId { get; set; }

        string Name { get; set; }
    }
}
