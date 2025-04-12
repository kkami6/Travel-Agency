using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;

namespace TestingLayer
{
    class CitiesContextTests
    {
        static CitiesContext citiesContext;

        public CitiesContextTests()
        {
            citiesContext = new CitiesContext(TestManager.dbContext);
        }

        [Test]
        public void CreateCity()
        {
            //Arrange
            City city = new City("Plovdiv", "Bulgaria");

            //Act
            citiesContext.Create(city);

            //Assert
            City lastCity = TestManager.dbContext.Cities.Last();
            Assert.That(lastCity.Name, Is.EqualTo(city.Name), "Cities' names do not match");
        }

        [Test]
        public void ReadCity()
        {
            City newCity = new City("Plovdiv", "Bulgaria");
            citiesContext.Create(newCity);

            City city = citiesContext.Read(1);

            Assert.That(city.Name == "Plovdiv", "The Read() test does not run properly.");

        }

        [Test]
        public void ReadAllCiities()
        {
            int citiesBefore = TestManager.dbContext.Cities.Count();

            int citiesAfter = citiesContext.ReadAll().Count;

            Assert.That(citiesBefore == citiesAfter, "The ReadAll() function does not return evrything");
        }

        [Test]
        public void UpdateCity()
        {
            City newCity = new City("Plovidv", "Bulgaria");
            citiesContext.Create(newCity);

            City lastCity = citiesContext.ReadAll().Last();
            lastCity.Name = "Updated City";

            citiesContext.Update(lastCity, false);

            Assert.That(citiesContext.Read(lastCity.CityId).Name == "Updated City");
        }

        [Test]

        public void DeleteCity()
        {
            City newCity = new City("Plovidv", "Bulgaria");
            citiesContext.Create(newCity);

            List<City> cities = citiesContext.ReadAll();
            int citiesBeofre = cities.Count();
            City lastCity = cities.Last();

            citiesContext.Delete(lastCity.CityId);

            int citiesAfter = citiesContext.ReadAll().Count;
            Assert.That(citiesBeofre == citiesAfter + 1, "the Delete() does not work.");
        }
    }
}
