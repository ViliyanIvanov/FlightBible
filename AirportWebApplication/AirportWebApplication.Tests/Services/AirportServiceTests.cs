
using AirportWebApplication.Data;
using AirportWebApplication.Services;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportWebApplication.Tests.Services
{
    class AirportServiceTests
    {
        private AirportService airportService;
        private AirportSystem_DbContext dbContext;
        [SetUp]
        public void Setup()
        {
            var dbContextOptions = new DbContextOptionsBuilder<AirportSystem_DbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            dbContext = new AirportSystem_DbContext(dbContextOptions);
            airportService = new AirportService(dbContext);
        }

        [Test]
        public void AddAirportWorks()
        {
            //Arrange
            var airport = new Airport { Id = "SOF", Name = "SofiaAirport", City = "Sofia", Country = "Bulgaria", Address = "Sofia, Bulgaria" };
            //Act
            airportService.AddAirport(airport);

            //Assert
            Assert.AreEqual(1, dbContext.Airports.Count());
        }

        [Test]
        public void AddAirportAlreadyExists()
        {
            //Arrange
            var airport = new Airport { Id = "SOF", Name = "SofiaAirport", City = "Sofia", Country = "Bulgaria", Address = "Sofia, Bulgaria" };
            var airportIdExists = new Airport { Id = "SOF", Name = "SofiaAirport1", City = "Sofia1", Country = "Bulgaria1", Address = "Sofia, Bulgaria1" };

            //Act
            airportService.AddAirport(airport);

            //Assert
            var exception = Assert.Throws<Exception>(() => airportService.AddAirport(airportIdExists));
            Assert.AreEqual("Airport with such ID already exists", exception.Message);
        }

        [Test]
        public void AddAirportIncorrectId()
        {
            
            var airport = new Airport { Id = "SO", Name = "SofiaAirport", City = "Sofia", Country = "Bulgaria", Address = "Sofia, Bulgaria" };
            
            
            var exception = Assert.Throws<Exception>(() => airportService.AddAirport(airport));
            Assert.AreEqual("Invalid input for ID", exception.Message);
        }
        [Test]
        public void ViewAirportsWorks()
        {
            //Arrange
            airportService.AddAirport(new Airport { Id = "SOF", Name = "SofiaAirport", City = "Sofia", Country = "Bulgaria", Address = "Sofia, Bulgaria" });
            airportService.AddAirport(new Airport { Id = "BUR", Name = "BurgasAirport", City = "Burgas", Country = "Bulgaria", Address = "Burgas, Bulgaria" });
            

            //Act
            var listReturned = airportService.ViewAirports();
            
            //Assert
            Assert.AreEqual(2, listReturned.Count());
        }
    }
}