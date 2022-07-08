using AirportWebApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Models
{
    public record FlightsListViewModel
    (
        int Id,
        Airport Origin,
        Airport Destination,
        DateTime TakeOffTime,
        DateTime LandingTime,
        List<Seat> Seats,
        int BookedCount
    );
}
