
using System.Collections.Generic;
using KraigsList.Models;

namespace KraigsList.db
{
    public class FakeDb
    {
        public static List<Car> Cars { get; set; } = new List<Car>();

        public static List<House> Houses { get; set; } = new List<House>();
    }
}