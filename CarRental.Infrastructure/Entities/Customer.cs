using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public List<Booking> Bookings { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
