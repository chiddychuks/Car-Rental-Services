using CarRental.Core.Interface.Repositories;
using CarRental.Core.Models;
using CarRental.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CarRental.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private DbContext _context;

        public CustomerRepository(DbContext context)
        {
            _context = context;
        }

        public Customer GetCustomerByEmail(string email)
        {
            var query = from customer in _context.Set<Entities.Customer>()
                        where customer.Email == email
                        select customer;

            var entity = query.FirstOrDefault();

            return entity.Map();
        }

        public Customer CreateCustomer(Customer customer)
        {
            var entity = customer.Map();
            _context.Set<Entities.Customer>().Add(entity);
            _context.SaveChanges();
            return entity.Map();
        }
    }
}
