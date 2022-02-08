using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.DAL.Repository.EmployeeRepo;
using TimeSheet.Entity.Models;

namespace TimeSheet.BAL.Services
{
    public class EmployeeServices
    {
        IEmployeeRepository _employeeRepository;
        public EmployeeServices(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public void AddTimeSheet(TimeSheetModel timesheet)
        {
            _employeeRepository.AddTimeSheet(timesheet);
        }

        public void DeleteTimeSheet(int timesheetID)
        {
            _employeeRepository.DeleteTimeSheet(timesheetID);
        }

        public void UpdateTimeSheet(TimeSheetModel timesheet)
        {
            _employeeRepository.UpdateTimeSheet(timesheet);
        }
    }
}
