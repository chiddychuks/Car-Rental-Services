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
    public class CarRepository : ICarRepository
    {
        private readonly DbContext _context;

        public CarRepository(DbContext context)
        {
            _context = context;
        }

        public Car Create(Car car)
        {
            var entity = car.Map();
            _context.Set<Entities.Car>().Add(entity);
            _context.SaveChanges();
            return entity.Map();
        }

        public List<Car> GetAvailableCars()
        {
            var closed = BookingStatus.Closed.ToString();
            var query = from car in _context.Set<Entities.Car>()
                        where car.Bookings.Any(b => b.Status != closed)
                        select car;
            var records = query.ToList();
            return records.Select(Mapper.Map).ToList();
        }

        public List<Car> GetCars(int ownerId)
        {
            var query = from car in _context.Set<Entities.Car>()
                        where car.OwnerId == ownerId
                        select car;

            var records = query.ToList();

            return records.Select(Mapper.Map).ToList();
        }
    }
}
