using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Data
{
    public class AirportSystem_DbContext:DbContext
    {
        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<Airline> Airlines { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public AirportSystem_DbContext(DbContextOptions options):base(options)
        {

        }
    }
}
