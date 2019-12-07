using System;
using System.Collections.Generic;
using System.Text;
using CarRental.Core.Models;

namespace CarRental.Core.Interface.Repositories
{
    public interface IOwnerRepository
    {
        Owner GetOwnerByEmail(string email);
        Owner CreateOwner(Owner customer);
    }
}
