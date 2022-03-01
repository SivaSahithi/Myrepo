using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CASESTUDYTIMESHEET2.models
{
    public class TimeSheet
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public DateTime EntryDate { get; set; }
        public int HoursSpend { get; set; }

        public string Status { get; set; }
        public string Description { get; set; }
    }
    public class Employee
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmailId { get; set; }
        public string passwords { get; set; }
        public string Job { get; set; }



    }

}
