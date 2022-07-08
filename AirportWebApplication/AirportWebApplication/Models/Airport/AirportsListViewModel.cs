using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Models
{
    public record AirportsListViewModel
    (
        string Id,
        string Name,
        string City,
        string Country,
        string Address
    );
}
