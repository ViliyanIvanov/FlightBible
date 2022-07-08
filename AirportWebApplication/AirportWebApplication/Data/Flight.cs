using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Data
{
    public class Flight
    {
        public Airline Airline { get; set; }
        public int AirlineId { get; set; }
        public Airport Origin { get; set; }
        public Airport Destination { get; set; }
        public DateTime TakeOffTime { get; set; }
        public DateTime LandingTime { get; set; }
        public List<Seat> Seats { get; set; }

        public int BookedCount { get; set; }
        public int OriginAirportId { get; set; }
        public int DestinationAirportId { get; set; }
        [Key]
        public int Id { get; set; }
    }
}

