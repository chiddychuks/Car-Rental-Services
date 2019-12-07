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
    public class OwnerController : Controller
    {
        private readonly IOwnerService _owner;

        public OwnerController(IOwnerService owner)
        {
            _owner = owner;
        }
        public IActionResult Index()
        {
            var email = User.FindFirst(ClaimTypes.Name).Value;
            var owner = _owner.GetOwnerByEmail(email);
            if (owner == null)
            {
                return RedirectToAction(nameof(Register));
            }

            var cars = _owner.GetCars(owner.OwnerId);
            return View(cars);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Car car)
        {
            try
            {
                var email = User.FindFirst(ClaimTypes.Name).Value;
                var newCar = _owner.CreateCar(email, car);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(car);
            }
        }

        public IActionResult Register()
        {
            var email = User.FindFirst(ClaimTypes.Name).Value;
            var owner = new Owner
            {
                Email = email
            };
            return View(owner);
        }

        [HttpPost]
        public IActionResult Register(Owner owner)
        {
            try
            {
                _owner.CreateOwner(owner);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("RegistrationError", $"Could not Create Owner {ex.Message}");
                return View(owner);
            }
        }
    }
}