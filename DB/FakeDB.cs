
using System.Collections.Generic;
using cars.Models;
using houses.Models;
using jobs.Models;

namespace cars.DB
{
  public static class FakeDB
  {
    public static List<Car> Cars { get; set; } = new List<Car>(){
        new Car("Honda","Civic",1991,2000,"https://s.aolcdn.com/commerce/autodata/images/USC90HOC021A121001.jpg","Buy it if you want. idc")
    };

  }
}
namespace houses.DB
{
  public static class FakeDB
  {
    public static List<House> Houses { get; set; } = new List<House>(){
        new House(3,2,1990,300000,"https://hgtvhome.sndimg.com/content/dam/images/hgtv/fullset/2019/2/7/3/BP_HHMTN310_Bolden_home-exterior_AFTER_0132.jpg.rend.hgtvcom.966.644.suffix/1549585070420.jpeg","Great starter home in Nampa, Id")
    };
  }
}
namespace jobs.DB
{
  public static class FakeDB
  {
    public static List<Job> Jobs { get; set; } = new List<Job>(){
        new Job("Boise Code Works","Teachers Aid",40,20,"Seeking Jr to Mid level developers for TA possition.")
    };
  }
}