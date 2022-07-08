
using AirportTask.Test.Mock;
using AirportWebApplication.Controllers;
using AirportWebApplication.Data;
using AirportWebApplication.Models;
using AirportWebApplication.Services;
using AirportWebApplication.Tests.Mock;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AirportTask.Test.Controllers
{
    public class AirportControllerTest
    {
        [Test]
        public void CreateShouldReturnView()
        {
            //Arrange
            var airportController = new AirportController(null);
            //Act
            var result = airportController.AddAirport();
            //Assert
            Assert.NotNull(result);
            Assert.IsInstanceOf<ViewResult>(result);
        }
        [Test]
        public void AddAirportRedirect()
        {
            //Arrange
            var airportsController = new AirportController(MockAirportService.AirportServiceMock.Object);

            //Act
            var result = airportsController.AddAirport(new AddAirportFormModel{Id = "SOF", Name = "Sofia Airport", City = "Sofia", Country = "Bulgaria", Address = "Sofia, Bulgaria"});
            
            //Assert
            var redirect = (RedirectToActionResult)result;
            Assert.AreEqual(redirect.ActionName, "AirportSuccessfulSubmission");
        }

        [Test]
        public void ViewAirportsReturnsView()
        {
            //Arrange
            var data = DatabaseMock.DbContext;
            data.Airports.AddRange(Enumerable.Range(0, 3).Select(x => new Airport{Id = "SOF", Name = "SofiaAirport", City = "Sofia", Country = "Bulgaria", Address = "Sofia, Bulgaria"}));
            data.SaveChanges();
            var airportService = new AirportService(data);
            var airportsController = new AirportController(airportService);

            //Act
            var actualResult = airportsController.ViewAirports();

            //Assert
            Assert.That(actualResult, Is.TypeOf<ViewResult>());
        }

    }
}