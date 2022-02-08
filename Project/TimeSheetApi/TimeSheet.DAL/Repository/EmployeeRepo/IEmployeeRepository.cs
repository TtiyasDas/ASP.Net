using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Entity.Models;

namespace TimeSheet.DAL.Repository.EmployeeRepo
{
    public interface IEmployeeRepository
    {
        public void AddTimeSheet(TimeSheetModel timesheet);
        public void DeleteTimeSheet(int timesheetID);
        public void UpdateTimeSheet(TimeSheetModel timesheet);
    }
}
