using AirportWebApplication.Data;
using AirportWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Services
{
    public interface IAirportService
    {
        public void AddAirport(Airport airport);
        public bool IsIdTaken(string Id);
        public bool IsNameTaken(string Name);
        public List<AirportsListViewModel> ViewAirports();
        public List<Airport> GetAllAirports();

        public bool DoesAirportExist(string AirportName);
    }
}
