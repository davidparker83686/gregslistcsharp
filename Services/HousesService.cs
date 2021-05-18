using System;
using System.Collections.Generic;
using houses.DB;
using houses.Models;

namespace houses.Services
{
  public class HousesService
  {
    internal IEnumerable<House> GetAll()
    {
      return FakeDB.Houses;
    }

    internal House GetById(string id)
    {
      House found = FakeDB.Houses.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal House Create(House newHouse)
    {
      FakeDB.Houses.Add(newHouse);
      return newHouse;
    }

    internal House Edit(House editHouse)
    {
      House oldHouse = GetById(editHouse.Id);
      oldHouse.Bedrooms = editHouse.Bedrooms;
      oldHouse.Bathrooms = editHouse.Bathrooms;
      oldHouse.Year = editHouse.Year;
      oldHouse.Price = editHouse.Price;
      oldHouse.ImgUrl = editHouse.ImgUrl;
      oldHouse.Description = editHouse.Description;

      return oldHouse;
    }

    internal void DeleteHouse(string id)
    {
      House found = GetById(id);
      FakeDB.Houses.Remove(found);
    }
  }
}
