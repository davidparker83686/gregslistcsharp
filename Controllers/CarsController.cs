using System;
using System.Collections.Generic;
using cars.DB;
using cars.Models;
using cars.Services;
using Microsoft.AspNetCore.Mvc;

namespace cars.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _service;
    public CarsController(CarsService service)
    {
      _service = service;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Car>> GetAll()
    {
      try
      {
        return Ok(FakeDB.Cars);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    // GETById
    [HttpGet("{id}")] // same as :id
    public ActionResult<Car> GetById(string id)
    {
      try
      {
        Car found = _service.GetById(id);
        return Ok(found);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // POST
    [HttpPost]
    // NOTE From the body, create a Car type object called newCar
    public ActionResult<Car> Create([FromBody] Car newCar)
    {
      try
      {
        Car car = _service.Create(newCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    // PUT
    [HttpPut("{id}")]
    public ActionResult<Car> Edit([FromBody] Car editCar, string id)
    {
      try
      {
        editCar.Id = id;
        Car car = _service.Edit(editCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    // DELETE
    [HttpDelete("{id}")]
    public ActionResult<string> DeleteCar(string id)
    {
      try
      {
        _service.DeleteCar(id);
        return Ok("Deleted Successfully");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }

    }
  }
}