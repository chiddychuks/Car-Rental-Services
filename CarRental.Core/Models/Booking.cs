using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Core.Models
{
    public class Booking: Model
    {
        public int BookingId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public Car Car { get; set; }
        public DateTime DateBooked { get; set; }
        public int Duration { get; set; }
        public BookingStatus Status { get; set; }
        public Customer Customer { get; set; }
    }
    public enum BookingStatus { Pending, Booked,  Closed }
}
