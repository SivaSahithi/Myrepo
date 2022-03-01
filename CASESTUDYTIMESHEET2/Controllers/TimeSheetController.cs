using CASESTUDYTIMESHEET2.models;
using CASESTUDYTIMESHEET2.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CASESTUDYTIMESHEET2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeSheetController : ControllerBase
    {
        private ITimeSheet tmps = new TimeSheetTemp();
        //private List<TimeSheet> tempemps;



        [HttpGet("Name")]
        public List<TimeSheet> GetEmployeeTimeSheetByName(string empname)
        {
            var result = tmps.GetByName(empname);

            return result;


        }

        [HttpGet("Date")]
        public List<TimeSheet> GetByDate(DateTime entryDate)
        {
            return tmps.GetDate(entryDate);
        }
        
       
    }
}

