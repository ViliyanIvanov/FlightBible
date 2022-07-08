using AirportWebApplication.Data;
using AirportWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Services
{
    public class FlightService : IFlightService
    {
        private readonly AirportSystem_DbContext DbContext;
        private readonly ISeatService _seats;
        public FlightService(AirportSystem_DbContext DbContext, ISeatService seats)
        {
            this.DbContext = DbContext;
            _seats = seats;
        }
        public bool DoesAirlineExist(string AirlineName)
        {
            return DbContext.Airlines.Any(x => x.Name == AirlineName);
        }


        public void AddFlight(AddFlightFormModel model)
        {

            var flight = new Flight
            {
                AirlineId = DbContext.Airlines.First(x => x.Name == model.AirlineName).Id,
                OriginAirportId = DbContext.Airports.First(x => x.Name == model.OriginAirportName).AirportId,
                DestinationAirportId = DbContext.Airports.First(x => x.Name == model.DestAirportName).AirportId,
                Airline = DbContext.Airlines.First(a => a.Name == model.AirlineName),
                Origin = DbContext.Airports.First(x => x.Name == model.OriginAirportName),
                Destination = DbContext.Airports.First(x => x.Name == model.DestAirportName),
                TakeOffTime = model.TakeOffTime,
                LandingTime = model.LandingTime
            };
            DbContext.Flights.Add(flight);
            DbContext.SaveChanges();
            _seats.AddSeat(model);

            DbContext.SaveChanges();
        }

        public List<FlightsListViewModel> FoundFlights(SearchFlightsFormModel searchFlightsFormModel)
        {
            var origin = DbContext.Airports.First(x => x.Name == searchFlightsFormModel.OriginAirportName);
            var destination = DbContext.Airports.First(x => x.Name == searchFlightsFormModel.DestAirportName);
            return DbContext.Flights.Where(x => x.Origin == origin && x.Destination == destination && x.TakeOffTime.Date == searchFlightsFormModel.Date).Select(x => new FlightsListViewModel(x.Id, x.Origin, x.Destination, x.TakeOffTime, x.LandingTime, x.Seats, x.BookedCount)).ToList();


        }
        public List<FlightsListViewModel> ViewFlights()
        {
            return DbContext.Flights.Select(x => new FlightsListViewModel(x.Id, x.Origin, x.Destination, x.TakeOffTime, x.LandingTime, x.Seats, x.BookedCount)).ToList();
        }
    }
}
