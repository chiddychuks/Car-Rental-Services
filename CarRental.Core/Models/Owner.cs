using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarRental.Core.Models
{
    public class Owner: Model
    {
        public int OwnerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public List<Car> Cars { get; set; } = new List<Car>();
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
