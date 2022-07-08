using AirportWebApplication.Data;
using AirportWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Services
{
    public class SeatService : ISeatService
    {
        private readonly AirportSystem_DbContext DbContext;
        public SeatService(AirportSystem_DbContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public void AddSeat(AddFlightFormModel flightModel)
        {
            var flightId = DbContext.Flights.OrderBy(x => x.Id).Last().Id;
            CreateSeats(ClassTypes.First, flightId, flightModel.rowsFirst, flightModel.colsFirst);
            CreateSeats(ClassTypes.Business, flightId, flightModel.rowsBusiness, flightModel.colsBusiness);
            CreateSeats(ClassTypes.Economy, flightId, flightModel.rowsEconomy, flightModel.colsEconomy);
            DbContext.SaveChanges();
        }
        public void CreateSeats(ClassTypes type, int flightId, int rows, int cols)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Seat seat = new Seat { IsBooked = false, Class = type, FlightId = flightId, Symbols = $"{i}{(char)(65 + j)}" };
                    DbContext.Seats.Add(seat);
                }
            }
        }
        public List<Seat> GetSeats(int flightid)
        {
            return DbContext.Seats.Where(x => x.FlightId == flightid).OrderBy(x => x.Class).ThenBy(x => x.Symbols).ToList();
        }

        public int BookSeat(int seatId)
        {
            var seat = DbContext.Seats.First(x => x.Id == seatId);
            if (!seat.IsBooked)
            {
                seat.IsBooked = true;
                var flight = DbContext.Flights.First(x => x.Id == seat.FlightId).BookedCount += 1;
                DbContext.SaveChanges();

            }
            return seat.FlightId;
        }
    }
}
