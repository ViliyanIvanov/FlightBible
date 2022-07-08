
using AirportWebApplication.Data;
using AirportWebApplication.Models;
using AirportWebApplication.Services;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AirportTask.Test.Mock
{
    public static class MockAirportService
    {
        public static Mock<IAirportService> AirportServiceMock
        {
            get
            {
                var airportServiceMock = new Mock<IAirportService>();

                var airport = new Airport { Id = "SOF", Name = "SofiaAirport", City = "Sofia", Country = "Bulgaria", Address = "Sofia, Bulgaria" };

                airportServiceMock.Setup(x => x.AddAirport(airport));



                airportServiceMock
                .Setup(x => x.ViewAirports())
                .Returns(Enumerable.Range(0, 5).Select(s => new AirportsListViewModel( Id: "SOF", Name: "SofiaAirport", City: "Sofia", Country: "Bulgaria", Address: "Sofia, Bulgaria")).ToList());



                airportServiceMock.Setup(x => x.AddAirport(airport));



                return airportServiceMock;
            }
        }
    }
}