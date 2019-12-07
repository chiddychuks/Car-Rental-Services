using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Entities
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public DateTime DateBooked { get; set; }
        public int Duration { get; set; }
        public string Status { get; set; }
        public Car Car { get; set; }
        public Customer Customer { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
