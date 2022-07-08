
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
    public static class MockAirlineService
    {
        public static Mock<IAirlineService> AirlineServiceMock
        {
            get
            {
                var airlineServiceMock = new Mock<IAirlineService>();

                var airline = new Airline {Name = "SOFIA"};

                airlineServiceMock.Setup(x => x.AddAirline(airline));



                airlineServiceMock
                .Setup(x => x.ViewAirlines())
                .Returns(Enumerable.Range(0, 5).Select(s => new AirlinesListViewModel(Name: "SofiaAirport")).ToList());



                airlineServiceMock.Setup(x => x.AddAirline(airline));



                return airlineServiceMock;
            }
        }
    }
}