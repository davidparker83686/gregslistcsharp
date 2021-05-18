using System;
using System.Collections.Generic;
using houses.DB;
using houses.Models;
using houses.Services;
using Microsoft.AspNetCore.Mvc;

namespace houses.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class HousesController : ControllerBase
  {
    private readonly HousesService _service;
    public HousesController(HousesService service)
    {
      _service = service;
    }
    [HttpGet]
    public ActionResult<IEnumerable<House>> GetAll()
    {
      try
      {
        return Ok(FakeDB.Houses);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    // GETById
    [HttpGet("{id}")] // same as :id
    public ActionResult<House> GetById(string id)
    {
      try
      {
        House found = _service.GetById(id);
        return Ok(found);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // POST
    [HttpPost]
    // NOTE From the body, create a House type object called newHouse
    public ActionResult<House> Create([FromBody] House newHouse)
    {
      try
      {
        House house = _service.Create(newHouse);
        return Ok(house);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    // PUT
    [HttpPut("{id}")]
    public ActionResult<House> Edit([FromBody] House editHouse, string id)
    {
      try
      {
        editHouse.Id = id;
        House house = _service.Edit(editHouse);
        return Ok(house);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    // DELETE
    [HttpDelete("{id}")]
    public ActionResult<string> DeleteHouse(string id)
    {
      try
      {
        _service.DeleteHouse(id);
        return Ok("Deleted Successfully");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }

    }
  }
}