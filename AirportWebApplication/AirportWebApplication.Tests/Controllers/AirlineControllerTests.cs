
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
    public class AirlineControllerTest
    {

        [Test]
        public void AddAirlineRedirects()
        {
            //Arrange
            var airlinesController = new AirlineController(MockAirlineService.AirlineServiceMock.Object);

            //Act
            var result = airlinesController.AddAirline(new AddAirlineFormModel{Name = "SOFIA"});
            
            //Assert
            var redirect = (RedirectToActionResult)result;
            Assert.AreEqual(redirect.ActionName, "AirlineSuccessfulSubmission");
        }

        [Test]
        public void ViewAirlinesReturnsView()
        {
            //Arrange
            var data = DatabaseMock.DbContext;
            data.Airlines.AddRange(Enumerable.Range(0, 3).Select(x => new Airline {Name = "SOFIA"}));
            data.SaveChanges();
            var airlineService = new AirlineService(data);
            var airlinesController = new AirlineController(airlineService);

            //Act
            var actualResult = airlinesController.ViewAirlines();

            //Assert
            Assert.That(actualResult, Is.TypeOf<ViewResult>());
        }

    }
}