using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string RegNumber { get; set; }
        public int OwnerId { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public List<Booking> Bookings { get; set; }
        public Owner Owner { get; set; }
    }
}
