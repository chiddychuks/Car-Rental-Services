using CarRental.Core.Interface.Repositories;
using CarRental.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CarRental.Infrastructure.Extensions;

namespace CarRental.Infrastructure.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly DbContext _context;

        public BookingRepository(DbContext context)
        {
            _context = context;
        }

        public List<Booking> GetBookings(int customerId)
        {
            var query = from booking in _context.Set<Entities.Booking>().Include(b => b.Customer).Include(b => b.Car)
                        where booking.CustomerId == customerId
                        select booking;

            var records = 
                query.ToList()
                    .Select(b =>
                    {
                        var booking = b.Map();
                        booking.Customer = b.Customer.Map();
                        booking.Car = b.Car.Map();
                        return booking;
                    }).ToList();

            return records;
        }
    }
}
