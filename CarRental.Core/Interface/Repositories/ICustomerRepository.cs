using System;
using System.Collections.Generic;
using System.Text;
using CarRental.Core.Models;

namespace CarRental.Core.Interface.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetCustomerByEmail(string email);
        Customer CreateCustomer(Customer customer);
    }
}
