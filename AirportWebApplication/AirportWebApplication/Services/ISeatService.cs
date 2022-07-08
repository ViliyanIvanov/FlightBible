using AirportWebApplication.Data;
using AirportWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Services
{
    public interface ISeatService
    {
        public void AddSeat(AddFlightFormModel flightModel);
        public void CreateSeats(ClassTypes type, int flightId, int rows, int cols);
        public List<Seat> GetSeats(int flightId);
        public int BookSeat(int seatId);
    }
}
