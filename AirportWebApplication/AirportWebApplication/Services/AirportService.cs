using AirportWebApplication.Data;
using AirportWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Services
{
    public class AirportService:IAirportService
    {
        private readonly AirportSystem_DbContext DbContext;

        public AirportService(AirportSystem_DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public bool IsIdTaken(string Id)
        {
            return !DbContext.Airports.Any(x => x.Id == Id);
        }public bool IsNameTaken(string Name)
        {
            return !DbContext.Airports.Any(x => x.Name == Name);
        }
        public bool DoesAirportExist(string AirportName)
        {
            return DbContext.Airports.Any(x => x.Name == AirportName);
        }

        public void AddAirport(Airport airport)
        {
            DbContext.Airports.Add(airport);
            DbContext.SaveChanges();
        }

        public List<AirportsListViewModel> ViewAirports()
        {
            return DbContext.Airports.Select(x => new AirportsListViewModel(x.Id, x.Name, x.City, x.Country, x.Address)).ToList();
        }

        public List<Airport> GetAllAirports()
        {
            return DbContext.Airports.ToList();
        }
    }
}
