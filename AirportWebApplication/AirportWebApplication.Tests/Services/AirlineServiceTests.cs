using AirportWebApplication.Data;
using AirportWebApplication.Services;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportWebApplication.Tests.Services
{
    class AirlineServiceTests
    {
        private AirlineService airlineService;
        private AirportSystem_DbContext dbContext;
        [SetUp]
        public void Setup()
        {
            var dbContextOptions = new DbContextOptionsBuilder<AirportSystem_DbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            dbContext = new AirportSystem_DbContext(dbContextOptions);
            airlineService = new AirlineService(dbContext);
        }

        [Test]
        public void AddAirlineWorks()
        {
            //Arrange
            var airline = new Airline { Id = 1, Name = "SOFIA"};
            //Act
            airlineService.AddAirline(airline);

            //Assert
            Assert.AreEqual(1, dbContext.Airlines.Count());
        }

        [Test]
        public void AddAirlineInvalidName()
        {
            //Arrange
            var airline = new Airline { Id = 1, Name = "SofiaAirlines" };

            //Assert
            var result = Assert.Throws<Exception>(() => airlineService.AddAirline(airline));
            Assert.AreEqual("Invalid input for Airline name", result.Message);
        }
        [Test]
        public void AddAirlineAlreadyExists()
        {
            //Arrange
            airlineService.AddAirline(new Airline{Name = "Sofia" });
            var airline1 = new Airline {Name = "Sofia" };

            //Assert
            var result = Assert.Throws<Exception>(() => airlineService.AddAirline(new Airline { Name = "Sofia" }));
            Assert.AreEqual("Airline with such name already exists", result.Message);

        }
        [Test]
        public void ViewAirlinesWorks()
        {
            //Arrange
            airlineService.AddAirline(new Airline {Name = "Sofia"});
            airlineService.AddAirline(new Airline {Name = "Burga"});


            //Act
            var listReturned = airlineService.ViewAirlines();

            //Assert
            Assert.AreEqual(2, listReturned.Count());
        }
    }
}
