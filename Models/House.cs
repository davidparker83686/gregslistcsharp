using System;
using System.ComponentModel.DataAnnotations;

namespace houses.Models

{

  public class House
  {
    public string Id { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int Year { get; set; }
    public int Price { get; set; }
    public string ImgUrl { get; set; }
    public string Description { get; set; }



    public House(int bedrooms, int bathrooms, int year, int price, string imgUrl, string description)
    {
      // this is temporary, the db will establish the id later
      Id = Guid.NewGuid().ToString();
      Bedrooms = bedrooms;
      Bathrooms = bathrooms;
      Year = year;
      Price = price;
      ImgUrl = imgUrl;
      Description = description;
    }
  }
}
