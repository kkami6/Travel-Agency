using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class HotelsContext: IDb<Hotel, int>
    {
        private TravelAgencyDbContext dbContext;

        public HotelsContext(TravelAgencyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Hotel item)
        {
            dbContext.Hotels.Add(item);
            dbContext.SaveChanges();
        }

        public Hotel Read(int key, bool useNavigationalProperties = false, bool isReadOnly = false)
        {
            IQueryable<Hotel> query = dbContext.Hotels;

            if (useNavigationalProperties) query = query.Include(g => g.Excursions);
            if (isReadOnly) query = query.AsNoTrackingWithIdentityResolution();

            Hotel hotel = query.FirstOrDefault(g => g.HotelId == key);

            if (hotel is null) throw new ArgumentException($"Hotel with id {key} does not exist!");

            return hotel;
        }

        public List<Hotel> ReadAll(bool useNavigationalProperties = false, bool isReadOnly = false)
        {
            IQueryable<Hotel> query = dbContext.Hotels;

            if (useNavigationalProperties) query = query.Include(g => g.Excursions);
            if (isReadOnly) query = query.AsNoTrackingWithIdentityResolution();

            return query.ToList();
        }

        public void Update(Hotel item, bool useNavigationalProperties = false)
        {
            Hotel hotelFromDb = Read(item.HotelId, useNavigationalProperties);

            if (useNavigationalProperties)
            {
                List<Excursion> excursions = new List<Excursion>();
                for (int i = 0; i < item.Excursions.Count; i++)
                {
                    Excursion excursionFromDb = dbContext.Excursions.Find(item.Excursions[i].ExcursionId);

                    if (excursionFromDb is not null) excursions.Add(excursionFromDb);
                    else excursions.Add(item.Excursions[i]);
                }
                hotelFromDb.Excursions = excursions;
            }

            dbContext.SaveChanges();
        }

        public void Delete(int key)
        {
            Hotel hotelFromDb = Read(key);
            dbContext.Hotels.Remove(hotelFromDb);
            dbContext.SaveChanges();
        }
    }
}
