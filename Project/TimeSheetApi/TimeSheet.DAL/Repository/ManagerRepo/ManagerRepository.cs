using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeSheet.DAL.Data;
using TimeSheet.Entity.Models;

namespace TimeSheet.DAL.Repository.ManagerRepo
{
    public class ManagerRepository:IManagerRepository
    {

        TimeSheetDbContext _timeSheetDBContext;
        public ManagerRepository(TimeSheetDbContext timeSheetDBContext)
        {
            _timeSheetDBContext = timeSheetDBContext;
        }
        public void AllocateProject(Employee employee)
        {
            _timeSheetDBContext.Entry(employee).State = EntityState.Modified;
            _timeSheetDBContext.SaveChanges();
        }

        public void ChangeEmpPsw(Employee employee)
        {
            _timeSheetDBContext.Entry(employee).State = EntityState.Modified;
            _timeSheetDBContext.SaveChanges();
        }

        public IEnumerable<Employee> GetEmployees(int mgrID)
        {
            return _timeSheetDBContext.employee.Where(obj => obj.EmpID == mgrID).ToList();
        }

        public TimeSheetModel GetTimeSheetByID(int empID)
        {
            return _timeSheetDBContext.timeSheet.Find(empID);
        }

        public void TimeSheetRelease(TimeSheetModel timeSheet)
        {
            _timeSheetDBContext.Entry(timeSheet).State = EntityState.Modified;
            _timeSheetDBContext.SaveChanges();
        }
    }
}
