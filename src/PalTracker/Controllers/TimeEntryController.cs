using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalTracker.Controllers
{
    [Route("/timeentry")]
    public class TimeEntryController: Controller
    {
        public ITimeEntryRepository database { get; set; }

        public TimeEntryController(ITimeEntryRepository repository)
        {
            database = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Json(database.List().AsQueryable());            
        }       

    }
}
