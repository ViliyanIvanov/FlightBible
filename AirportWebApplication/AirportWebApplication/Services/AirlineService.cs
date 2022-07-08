using AirportWebApplication.Data;
using AirportWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebApplication.Services
{
    public class AirlineService : IAirlineService
    {
        private readonly AirportSystem_DbContext DbContext;
        public AirlineService(AirportSystem_DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public bool IsNameTaken(string airlineName)
        {
            return !DbContext.Airlines.Any(x => x.Name == airlineName);
        }
        public bool DoesAirlineExist(string AirlineName)
        {
            return DbContext.Airlines.Any(x => x.Name == AirlineName);
        }
        public void AddAirline(Airline airline)
        {
                DbContext.Airlines.Add(airline);
                DbContext.SaveChanges();
        }
        public List<AirlinesListViewModel> ViewAirlines()
        {
            return DbContext.Airlines.Select(x => new AirlinesListViewModel(x.Name)).ToList();
        }
    }
}
