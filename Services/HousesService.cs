using System;
using System.Collections.Generic;
using KraigsList.db;
using KraigsList.Models;

namespace KraigsList.Services
{
    public class HousesService
    {
        public IEnumerable<House> Get()
        {
            return FakeDb.Houses;
        }
        public House GetHouseById(string id)
        {
            House House = FakeDb.Houses.Find(h => h.Id == id);
            if (House == null)
            {
                throw new Exception("Invalid id");
            }
            return House;
        }

        public House Create(House newHouse)
        {
            FakeDb.Houses.Add(newHouse);
            return newHouse;
        }

        public House Edit(House updated)
        {
            House editHouse = FakeDb.Houses.Find(h => h.Id == updated.Id);
            if (editHouse == null)
            {
                throw new System.Exception("Invalid");
            }
            FakeDb.Houses.Remove(editHouse);
            FakeDb.Houses.Add(updated);
            return updated;
        }

        public string Delete(string id)
        {
            House HouseToRemove = FakeDb.Houses.Find(House => House.Id == id);
            if (HouseToRemove == null)
            {
                throw new Exception("House Purchased");
            }
            FakeDb.Houses.Remove(HouseToRemove);
            return "Purchased House";
        }
    }


}