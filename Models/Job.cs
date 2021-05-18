using System;
using System.ComponentModel.DataAnnotations;

namespace jobs.Models

{

  public class Job
  {
    public string Id { get; set; }
    public string Company { get; set; }
    public string Title { get; set; }
    public int Hours { get; set; }
    public int Rate { get; set; }
    public string Description { get; set; }



    public Job(string company, string title, int hours, int rate, string description)
    {
      // this is temporary, the db will establish the id later
      Id = Guid.NewGuid().ToString();
      Company = company;
      Title = title;
      Hours = hours;
      Rate = rate;
      Description = description;
    }
  }
}
