using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace TestingLayer
{
    [TestFixture]
    internal class HotelsContextTests
    {
        HotelsContext hotelsContext;

        public HotelsContextTests()
        {
            hotelsContext = new HotelsContext(TestManager.dbContext);
        }

        [Test]
        public void CreateHotel()
        {
            Hotel newHotel = new Hotel(1, "str.Tsarevets 11", "Star Hotel", 4, false, true);

            hotelsContext.Create(newHotel);

            Hotel lastHotel = TestManager.dbContext.Hotels.Last();
            Assert.That(newHotel.HotelId, Is.EqualTo(lastHotel.HotelId), "The Create() method does not work! :(");
        }

        [Test]
        public void ReadHotel()
        {
            Hotel newHotel = new Hotel(1, "str.Tsarevets 11", "Star Hotel", 4, false, true);
            hotelsContext.Create(newHotel);

            Hotel hotel = hotelsContext.Read(1);

            Assert.That(newHotel.Name == hotel.Name, "The Read() method does not work! :(");
        }

        [Test]
        public void ReadAllHotels()
        {
            int hotelsBefore = TestManager.dbContext.Hotels.Count();

            int hotelsAfter = hotelsContext.ReadAll().Count;

            Assert.That(hotelsBefore == hotelsAfter, "The ReadAll() method does not work. :(");
        }

        [Test]

        public void UpdateHotel()
        {
            Hotel newHotel = new Hotel(1, "str.Tsarevets 11", "Star Hotel", 4, false, true);
            hotelsContext.Create(newHotel);

            Hotel lastHotel = hotelsContext.ReadAll().Last();
            lastHotel.Name = "Universal Hotel";

            hotelsContext.Update(lastHotel);

            Assert.That(lastHotel.Name == "Universal Hotel", "The update() method does not work. :(");
        }

        [Test]

        public void DeleteHotel() 
        {
            Hotel newHotel = new Hotel(1, "str.Tsarevets 11", "Star Hotel", 4, false, true);
            hotelsContext.Create(newHotel);

            List<Hotel> hotels = hotelsContext.ReadAll();
            int hotelsBefore = hotels.Count();
            Hotel lastHotel = hotels.Last();

            hotelsContext.Delete(lastHotel.HotelId);

            int hotelsAfter = TestManager.dbContext.Hotels.Count();
            Assert.That(hotelsBefore == hotelsAfter + 1, "The delete() method does not work. :(");
        }
    }
}
