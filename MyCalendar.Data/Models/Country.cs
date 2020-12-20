using System;

namespace MyCalendar.Data.Models
{
    public class Country
    {
        public Guid Id { get; set; }

        public string EnName { get; set; }

        public string UnCode { get; set; }

        public string Alpha2 { get; set; }

        public string Alpha3 { get; set; }

        public string ImagePath { get; set; }
    }
}
