using System;
using System.Collections.Generic;
using System.Text;
using CarRental.Core.Models;

namespace CarRental.Core.Interface.Repositories
{
    public interface IBookingRepository
    {
        List<Booking> GetBookings(int customerId);
    }
}
