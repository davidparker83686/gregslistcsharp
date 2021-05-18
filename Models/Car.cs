using System;
using System.ComponentModel.DataAnnotations;

namespace cars.Models

{
  public class Car
  {
    public string Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Price { get; set; }
    public string ImgUrl { get; set; }
    public string Description { get; set; }



    public Car(string make, string model, int year, int price, string imgUrl, string description)
    {
      // this is temporary, the db will establish the id later
      Id = Guid.NewGuid().ToString();
      Make = make;
      Model = model;
      Year = year;
      Price = price;
      ImgUrl = imgUrl;
      Description = description;
    }
  }
}
