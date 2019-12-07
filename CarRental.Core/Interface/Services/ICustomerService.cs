using CarRental.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Core.Interface.Services
{
    public interface ICustomerService
    {
        Customer GetCustomerByEmail(string email);
        Customer CreateCustomer(Customer customer);
    }
}
