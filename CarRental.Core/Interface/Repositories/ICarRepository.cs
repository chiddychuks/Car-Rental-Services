using System;
using System.Collections.Generic;
using System.Text;
using CarRental.Core.Models;

namespace CarRental.Core.Interface.Repositories
{
    public interface ICarRepository
    {
        List<Car> GetAvailableCars();
        List<Car> GetCars(int ownerId);
        Car Create(Car car);
    }
}
