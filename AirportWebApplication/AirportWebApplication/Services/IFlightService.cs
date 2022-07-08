using AirportWebApplication.Data;
using AirportWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Services
{
    public interface IFlightService
    {
        public void AddFlight(AddFlightFormModel model);
        public List<FlightsListViewModel> ViewFlights();
        public List<FlightsListViewModel> FoundFlights(SearchFlightsFormModel searchFlightsFormModel);

    }
}
