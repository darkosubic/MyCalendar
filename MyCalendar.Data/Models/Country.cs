using System;

namespace MyCalendar.Data.Models
{
    public record Country
    {
        public Country(Guid id, 
            string enName, 
            string unCode, 
            string alpha2, 
            string alpha3, 
            string imagePath)
            => (Id, EnName, UnCode, Alpha2, Alpha3, ImagePath) =
            (id, enName, unCode, alpha2, alpha3, imagePath);

        public Guid Id { get; }

        public string EnName { get; }

        public string UnCode { get; }

        public string Alpha2 { get; }

        public string Alpha3 { get; }

        public string ImagePath { get; }
    }
}
