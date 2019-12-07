using CarRental.Core.Interface.Repositories;
using CarRental.Core.Interface.Services;
using CarRental.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Core.Services
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customer;

        public CustomerService(ICustomerRepository customer)
        {
            _customer = customer;
        }
        public Customer CreateCustomer(Customer customer)
        {
            customer.Validate();
            var existingCustomer = _customer.GetCustomerByEmail(customer.Email);
            if(existingCustomer == null)
            {
                var newCustomer = _customer.CreateCustomer(customer);
                return newCustomer;
            }
            else
            {
                throw new Exception("Customer already exists");
            }
        }

        public Customer GetCustomerByEmail(string email)
        {
            return _customer.GetCustomerByEmail(email);
        }
    }
}
