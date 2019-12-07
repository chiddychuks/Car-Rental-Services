using CarRental.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Core.Interface.Services
{
    public interface IBookingService
    {
        List<Booking> GetBookings(string email);
    }
}
