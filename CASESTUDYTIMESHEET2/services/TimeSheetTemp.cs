using CASESTUDYTIMESHEET2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CASESTUDYTIMESHEET2.services
{
    public class TimeSheetTemp : ITimeSheet
    {
        List<TimeSheet> details = new List<TimeSheet>
        {
            new TimeSheet
            {
                Id=1,
                EmpId=21475,
                EmpName="sahithi",
                EntryDate=DateTime.Today,
                HoursSpend=40,
                Status="pending for approval"

            },
            new TimeSheet
            {
                Id=2,
                EmpId=21475,
                EmpName="sahithi",
                EntryDate=DateTime.Today.AddDays(-7),
                HoursSpend=40,
                Status="approved"
            },
            new TimeSheet
            {
                Id=3,
                EmpId=21468,
                EmpName="sruthi",
                EntryDate=DateTime.Today.AddDays(-14),
                HoursSpend=40,
                Status="approved"


            },
            
            new TimeSheet
            {
                Id=4,
                EmpId=21468,
                EmpName="sruthi",
                EntryDate=DateTime.Today,
                HoursSpend=40,
                Status="pending for approval"



            },
            new TimeSheet
            {
                Id=5,
                EmpId=21485,
                EmpName="pratiba",
                EntryDate=DateTime.Today,
                HoursSpend=40,
                Status="pending for approval"

            },
            new TimeSheet
            {
                Id=6,
                EmpId=21485,
                EmpName="pratiba",
                EntryDate=DateTime.Today.AddDays(-7),
                HoursSpend=40,
                Status="pending for approval"

            },
            new TimeSheet
            {
                Id=7,
                EmpId=21486,
                EmpName="gokul",
                EntryDate=DateTime.Today.AddDays(-1),
                HoursSpend=40,
                Status="pending for approval"

            },
            new TimeSheet
            {
                Id=8,
                EmpId=21486,
                EmpName="gokul",
                EntryDate=DateTime.Today,
                HoursSpend=40,
                Status="approved"

            },
            new TimeSheet
            {
                Id=9,
                EmpId=21487,
                EmpName="rohith",
                EntryDate=DateTime.Today.AddDays(-1),
                HoursSpend=40,
                Status="approved"

            },

        };

        

        public List<TimeSheet> GetByName(string empname)
        {
            var result = details.FindAll(x => x.EmpName == empname);
            var res = result.Where(e => e.Status.ToLower() == "pending for approval").ToList();
            return res;
        }

        public List<TimeSheet> GetDate(DateTime entryDate)
        {
            return details.FindAll(x => x.EntryDate == entryDate);
        }
    }
}
