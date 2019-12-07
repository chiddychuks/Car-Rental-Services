using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Entities
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Car> Cars { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
