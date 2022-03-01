using CASESTUDYTIMESHEET2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CASESTUDYTIMESHEET2.services
{
    public interface ITimeSheet
    {
        List<TimeSheet> GetByName(string empname);
        List<TimeSheet> GetDate(DateTime entryDate);
        
    }
}
