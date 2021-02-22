

using System;
using System.Collections.Generic;
using KraigsList.db;
using KraigsList.Models;

namespace KraigsList.Services
{
    public class CarsService
    {
        public IEnumerable<Car> Get()
        {
            return FakeDb.Cars;
        }

        public Car Get(string id)
        {
            Car carToFind = FakeDb.Cars.Find(c => c.Id == id);
            if (carToFind == null)
            {
                throw new Exception("Invalid id");
            }
            return carToFind;
        }
        public Car GetCarById(string id)
        {
            Car Car = FakeDb.Cars.Find(c => c.Id == id);
            if (Car == null)
            {
                throw new Exception("Invalid id");
            }
            return Car;
        }

        public Car Create(Car newCar)
        {
            FakeDb.Cars.Add(newCar);
            return newCar;
        }

        public Car Edit(Car updated)
        {
            Car editCar = FakeDb.Cars.Find(c => c.Id == updated.Id);
            if (editCar == null)
            {
                throw new System.Exception("Invalid");
            }
            FakeDb.Cars.Remove(editCar);
            FakeDb.Cars.Add(updated);
            return updated;
        }

        public string Delete(string id)
        {
            Car carToRemove = FakeDb.Cars.Find(car => car.Id == id);
            if (carToRemove == null)
            {
                throw new Exception("Car Obliterated");
            }
            FakeDb.Cars.Remove(carToRemove);
            return "Deleted";
        }
    }


}