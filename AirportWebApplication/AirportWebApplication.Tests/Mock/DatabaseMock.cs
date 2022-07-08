using AirportWebApplication.Data;
using Microsoft.EntityFrameworkCore;
using System;
namespace AirportWebApplication.Tests.Mock
{
    public static class DatabaseMock
    {
        public static AirportSystem_DbContext DbContext
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<AirportSystem_DbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;

                return new AirportSystem_DbContext(dbContextOptions);
            }
        }
    }
}