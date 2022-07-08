using AirportWebApplication.Data;
using AirportWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Services
{
    public interface IAirlineService
    {
        public void AddAirline(Airline airline);
        public bool IsNameTaken(string airlineName);
        public List<AirlinesListViewModel> ViewAirlines();
        public bool DoesAirlineExist(string airlineName);
    }
}
