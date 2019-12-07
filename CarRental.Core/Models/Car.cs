using System;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Core.Models
{
    public class Car: Model
    {
        public int CarId { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string RegNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public int OwnerId { get; set; }
    }
}