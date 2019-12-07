using CarRental.Core.Interface.Repositories;
using CarRental.Core.Interface.Services;
using CarRental.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Core.Services
{
    public class BookingService : IBookingService
    {
        private readonly ICustomerRepository _customer;
        private readonly IBookingRepository _booking;

        public BookingService(IBookingRepository booking, ICustomerRepository customer)
        {
            _customer = customer;
            _booking = booking;
        }

        public List<Booking> GetBookings(string email)
        {
            var customer = _customer.GetCustomerByEmail(email);
            if (customer == null) return new List<Booking>();
            return _booking.GetBookings(customer.CustomerId);
        }
    }
}
