using DataLayer;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;


namespace TestingLayer

{
    [TestFixture]
    public class TestManager
    {
        internal static TravelAgencyDbContext dbContext;

        static TestManager()
        {
            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase("TestDb");
            dbContext = new TravelAgencyDbContext(builder.Options);
        }

        [OneTimeTearDown]
        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}