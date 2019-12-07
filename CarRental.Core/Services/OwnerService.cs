using CarRental.Core.Interface.Repositories;
using CarRental.Core.Interface.Services;
using CarRental.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Core.Services
{
    public class OwnerService: IOwnerService
    {
        private ICarRepository _car;
        private IOwnerRepository _owner;

        public OwnerService(IOwnerRepository owner, ICarRepository car)
        {
            _car = car;
            _owner = owner;
        }
        public Owner CreateOwner(Owner owner)
        {
            owner.Validate();
            var existingCustomer = _owner.GetOwnerByEmail(owner.Email);
            if (existingCustomer == null)
            {
                var newOwner = _owner.CreateOwner(owner);
                return newOwner;
            }
            else
            {
                throw new Exception("Owner already exists");
            }
        }

        public Owner GetOwnerByEmail(string email)
        {
            return _owner.GetOwnerByEmail(email);
        }

        public List<Car> GetAvailableCars()
        {
            return _car.GetAvailableCars();
        }

        public List<Car> GetCars(int ownerId)
        {
            return _car.GetCars(ownerId);
        }

        public Car CreateCar(string email, Car car)
        {
            var owner = _owner.GetOwnerByEmail(email);
            if (owner == null) throw new Exception("Invalid Owner Email");

            car.Validate();
            car.OwnerId = owner.OwnerId;

            var newCar = _car.Create(car);
            return newCar;
        }
    }
}
