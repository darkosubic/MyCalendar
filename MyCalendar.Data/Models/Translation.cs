using System;

namespace MyCalendar.Data.Models
{
    public record Translation
    {
        public Translation(Guid id, 
            Guid countryId, 
            string name)
            => (Id, CountryId, Name)
            = (id, countryId, name);

        Guid Id { get; }

        Guid CountryId { get; }

        string Name { get; }
    }
}
