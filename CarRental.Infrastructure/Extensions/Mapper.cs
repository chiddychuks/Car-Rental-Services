using CarRental.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Extensions
{
    public static class Mapper
    {
        public static Entities.Customer Map(this Customer customer)
        {
            if (customer == null) return null;
            return new Entities.Customer
            {
                Address = customer.Address,
                City = customer.City,
                Email = customer.Email,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
            };
        }

        public static Customer Map(this Entities.Customer entity)
        {
            if (entity == null) return null;
            return new Customer
            {
                CustomerId = entity.CustomerId,
                Address = entity.Address,
                City = entity.City,
                Email = entity.Email,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
            };
        }

        public static Booking Map(this Entities.Booking entity)
        {
            if (entity == null) return null;
            return new Booking
            {
                BookingId = entity.BookingId,
                CarId = entity.CarId,
                CustomerId = entity.CustomerId,
                DateBooked = entity.DateBooked,
                Duration = entity.Duration,
            };
        }

        public static Entities.Booking Map(this Booking booking)
        {
            if (booking == null) return null;
            return new Entities.Booking
            {
                BookingId = booking.BookingId,
                CarId = booking.CarId,
                CustomerId = booking.CustomerId,
                DateBooked = booking.DateBooked,
                Duration = booking.Duration,
            };
        }

        public static Owner Map(this Entities.Owner entity)
        {
            if (entity == null) return null;
            return new Owner
            {
                DateCreated = entity.DateCreated,
                Email = entity.Email,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                OwnerId = entity.OwnerId
            };
        }

        public static Entities.Owner  Map(this Owner owner)
        {
            if (owner == null) return null;
            return new Entities.Owner
            {
                DateCreated = owner.DateCreated,
                Email = owner.Email,
                FirstName = owner.FirstName,
                LastName = owner.LastName,
            };
        }

        public static Entities.Car Map(this Car car)
        {
            if (car == null) return null;
            return new Entities.Car
            {
                Make = car.Make,
                Model = car.Model,
                OwnerId = car.OwnerId,
                RegNumber = car.RegNumber,
            };
        }

        public static Car Map(this Entities.Car entity)
        {
            if (entity == null) return null;
            return new Car
            {
                CarId = entity.CarId,
                DateCreated = entity.DateCreated,
                Make = entity.Make,
                Model = entity.Model,
                OwnerId = entity.OwnerId,
                RegNumber = entity.RegNumber
            };
        }
    }
}
