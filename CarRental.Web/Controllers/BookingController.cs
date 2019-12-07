using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CarRental.Core.Interface.Services;
using CarRental.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Web.Controllers
{
    [Authorize]
    public class BookingController : Controller
    {
        private readonly ICustomerService _customer;
        private readonly IBookingService _booking;

        public BookingController(IBookingService booking, ICustomerService customer)
        {
            _customer = customer;
            _booking = booking;
        }
        public IActionResult Index()
        {
            var email = User.FindFirst(ClaimTypes.Name).Value;
            var customer = _customer.GetCustomerByEmail(email);
            if(customer == null)
            {
                return RedirectToAction(nameof(Register));
            }

            var bookings = _booking.GetBookings(email);
            return View(bookings);
        }

        public IActionResult Register()
        {
            var email = User.FindFirst(ClaimTypes.Name).Value;
            var customer = new Customer
            {
                Email = email
            };
            return View(customer);
        }

        [HttpPost]
        public IActionResult Register(Customer customer)
        {
            try
            {
                _customer.CreateCustomer(customer);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("RegistrationError", $"Could not Create Customer {ex.Message}");
                return View(customer);
            }
        }

    }
}