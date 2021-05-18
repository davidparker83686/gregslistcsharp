using System;
using System.Collections.Generic;
using jobs.DB;
using jobs.Models;

namespace jobs.Services
{
  public class JobsService
  {
    internal IEnumerable<Job> GetAll()
    {
      return FakeDB.Jobs;
    }

    internal Job GetById(string id)
    {
      Job found = FakeDB.Jobs.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal Job Create(Job newJob)
    {
      FakeDB.Jobs.Add(newJob);
      return newJob;
    }

    internal Job Edit(Job editJob)
    {
      Job oldJob = GetById(editJob.Id);
      oldJob.Company = editJob.Company;
      oldJob.Title = editJob.Title;
      oldJob.Hours = editJob.Hours;
      oldJob.Rate = editJob.Rate;
      oldJob.Description = editJob.Description;
      return oldJob;
    }

    internal void DeleteJob(string id)
    {
      Job found = GetById(id);
      FakeDB.Jobs.Remove(found);
    }
  }
}
