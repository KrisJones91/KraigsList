

using System;
using System.ComponentModel.DataAnnotations;

namespace KraigsList.Models
{
    public class Car
    {
        public Car(string make, string model, string description, int year, float price)
        {
            Make = make;
            Model = model;
            Description = description;
            Year = year;
            Price = price;
        }

        [Required]
        [MinLength(3)]
        public string Make { get; set; }
        public string Model { get; set; }
        [MaxLength(30)]
        public string Description { get; set; }
        [Range(100, 120000)]
        public float Price { get; set; }
        [Range(1925, 2021)]
        public int Year { get; set; }

        public string Id { get; set; } = Guid.NewGuid().ToString();

        public bool wasSet { get; set; }
        private int _someInt;
        public int someInt
        {
            get
            {
                return _someInt;
            }
            set
            {
                wasSet = true;
                _someInt = value;
            }
        }
    }
}