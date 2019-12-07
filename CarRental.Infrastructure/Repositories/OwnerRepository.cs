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
    public class OwnerRepository : IOwnerRepository
    {
        private DbContext _context;

        public OwnerRepository(DbContext context)
        {
            _context = context;
        }
        public Owner CreateOwner(Owner owner)
        {
            var entity = owner.Map();
            _context.Set<Entities.Owner>().Add(entity);
            _context.SaveChanges();
            return entity.Map();
        }

        public Owner GetOwnerByEmail(string email)
        {
            var query = from owner in _context.Set<Entities.Owner>()
                        where owner.Email == email
                        select owner;

            var entity = query.FirstOrDefault();

            return entity.Map();
        }
    }
}
