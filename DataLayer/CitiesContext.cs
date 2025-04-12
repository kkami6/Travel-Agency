using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CitiesContext: IDb<City, int>
    {
        private TravelAgencyDbContext dbContext;

        public CitiesContext(TravelAgencyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(City item)
        {
            dbContext.Cities.Add(item);
            dbContext.SaveChanges();
        }

        public City Read(int key, bool useNavigationalProperties = false, bool isReadOnly = false)
        {
            IQueryable<City> query = dbContext.Cities;

            if (useNavigationalProperties)
            {
                query = query.Include(g => g.Excursions);
                query = query.Include(g => g.Hotels);
            }
            if (isReadOnly) query = query.AsNoTrackingWithIdentityResolution();

            City city = query.FirstOrDefault(g => g.CityId == key);

            if (city is null) throw new ArgumentException($"City with id {key} does not exist!");

            return city;
        }

        public List<City> ReadAll(bool useNavigationalProperties = false, bool isReadOnly = false)
        {
            IQueryable<City> query = dbContext.Cities;

            if (useNavigationalProperties)
            {
                query = query.Include(g => g.Excursions);
                query = query.Include(g => g.Hotels);
            }
            if (isReadOnly) query = query.AsNoTrackingWithIdentityResolution();

            return query.ToList();
        }

        public void Update(City item, bool useNavigationalProperties = false)
        {
            City cityFromDb = Read(item.CityId, useNavigationalProperties);
            dbContext.Entry<City>(cityFromDb).CurrentValues.SetValues(item);

            if (useNavigationalProperties)
            {
                List<Excursion> excursions = new List<Excursion>();
                for (int i = 0; i < item.Excursions.Count; i++)
                {
                    Excursion excursionFromDb = dbContext.Excursions.Find(item.Excursions[i].ExcursionId);

                    if (excursionFromDb is not null) excursions.Add(excursionFromDb);
                    else excursions.Add(item.Excursions[i]);
                }
                cityFromDb.Excursions = excursions;

                List<Hotel> hotels = new List<Hotel>();
                for (int i = 0; i < item.Hotels.Count; i++)
                {
                    Hotel hotelFromDb = dbContext.Hotels.Find(item.Hotels[i].HotelId);

                    if (hotelFromDb is not null) hotels.Add(hotelFromDb);
                    else hotels.Add(item.Hotels[i]);
                }
                cityFromDb.Hotels = hotels;
            }

            dbContext.SaveChanges();
        }

        public void Delete(int key)
        {
            City cityFromDb = Read(key);
            dbContext.Cities.Remove(cityFromDb);
            dbContext.SaveChanges();
        }
    }
}
