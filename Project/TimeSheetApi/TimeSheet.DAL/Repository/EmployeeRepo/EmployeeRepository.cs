using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.DAL.Data;
using TimeSheet.Entity.Models;

namespace TimeSheet.DAL.Repository.EmployeeRepo
{
    public class EmployeeRepository:IEmployeeRepository
    {
        TimeSheetDbContext _timeSheetDBContext;
        public EmployeeRepository(TimeSheetDbContext timeSheetDBContext)
        {
            _timeSheetDBContext = timeSheetDBContext;
        }
        public void AddTimeSheet(TimeSheetModel timesheet)
        {
            _timeSheetDBContext.timeSheet.Add(timesheet);
            _timeSheetDBContext.SaveChanges();
        }

        public void DeleteTimeSheet(int timesheetID)
        {
            var timesheet = _timeSheetDBContext.timeSheet.Find(timesheetID);
            _timeSheetDBContext.timeSheet.Remove(timesheet);
            _timeSheetDBContext.SaveChanges();
        }

        public void UpdateTimeSheet(TimeSheetModel timesheet)
        {
            _timeSheetDBContext.Entry(timesheet).State = EntityState.Modified;
            _timeSheetDBContext.SaveChanges();
        }
    }
}
