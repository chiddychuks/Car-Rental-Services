using CarRental.Core.Models;
using System.Collections.Generic;

namespace CarRental.Core.Interface.Services
{
    public interface IOwnerService
    {
        Owner GetOwnerByEmail(string email);
        Owner CreateOwner(Owner owner);

        List<Car> GetCars(int ownerId);
        List<Car> GetAvailableCars();
        Car CreateCar(string email, Car car);
    }
}