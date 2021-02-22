using System;
using System.ComponentModel.DataAnnotations;

namespace KraigsList.Models
{
    public class House
    {
        [Required]
        public string Address { get; set; }
        [Range(1, 5)]
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        [Range(100, 500000000)]
        public int Price { get; set; }

        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}