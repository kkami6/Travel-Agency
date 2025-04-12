using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Excursion
    {
        [Key]
        public int ExcursionId { get; set; }

        [Required]
        [ForeignKey("City")]
        public int CityId { get; set; }

        [Required]
        [ForeignKey("Hotel")]
        public int HotelId { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime DepartureDate { get; set; }

        [Required]
        public DateTime ReturnDate { get; set; }

        public List<Client> Clients { get; set; }

        public List<Employee> Employees { get; set; }

        private Excursion() { }

        public Excursion(int cityId, int hotelId, decimal price, DateTime departuteDate, DateTime returnDate)
        {
            CityId = cityId;
            HotelId = hotelId;
            Price = price;
            DepartureDate = departuteDate;
            ReturnDate = returnDate;
            Clients = new List<Client>();
            Employees = new List<Employee>();
        }
    }
}
