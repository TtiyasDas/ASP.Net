using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Entity.Models;

namespace TimeSheet.DAL.Repository.ManagerRepo
{
    public interface IManagerRepository
    {
        public IEnumerable<Employee> GetEmployees(int mgrID);
        public TimeSheetModel GetTimeSheetByID(int mgrID);
        public void TimeSheetRelease(TimeSheetModel timeSheet);
        public void ChangeEmpPsw(Employee employee);
        public void AllocateProject(Employee employee);
    }
}
