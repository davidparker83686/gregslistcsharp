using System;
using System.Collections.Generic;
using jobs.DB;
using jobs.Models;
using jobs.Services;
using Microsoft.AspNetCore.Mvc;

namespace jobs.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class JobsController : ControllerBase
  {
    private readonly JobsService _service;
    public JobsController(JobsService service)
    {
      _service = service;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Job>> GetAll()
    {
      try
      {
        return Ok(FakeDB.Jobs);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    // GETById
    [HttpGet("{id}")] // same as :id
    public ActionResult<Job> GetById(string id)
    {
      try
      {
        Job found = _service.GetById(id);
        return Ok(found);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // POST
    [HttpPost]
    // NOTE From the body, create a Job type object called newJob
    public ActionResult<Job> Create([FromBody] Job newJob)
    {
      try
      {
        Job job = _service.Create(newJob);
        return Ok(job);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    // PUT
    [HttpPut("{id}")]
    public ActionResult<Job> Edit([FromBody] Job editJob, string id)
    {
      try
      {
        editJob.Id = id;
        Job job = _service.Edit(editJob);
        return Ok(job);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    // DELETE
    [HttpDelete("{id}")]
    public ActionResult<string> DeleteJob(string id)
    {
      try
      {
        _service.DeleteJob(id);
        return Ok("Deleted Successfully");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }

    }
  }
}