using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Entity.Models;
using TimeSheet.DAL.Repository.ManagerRepo;

namespace TimeSheet.BAL.Services
{
    public class ManagerServices
    {
        IManagerRepository _managerRepository;
        public ManagerServices(IManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }
        public void AllocateProject(Employee employee)
        {
            _managerRepository.AllocateProject(employee);
        }

        public void ChangeEmpPsw(Employee employee)
        {
            _managerRepository.ChangeEmpPsw(employee);
        }

        public IEnumerable<Employee> GetEmployees(int mgrID)
        {
            return _managerRepository.GetEmployees(mgrID);
        }

        public TimeSheetModel GetTimeSheetByID(int empID)
        {
            return _managerRepository.GetTimeSheetByID(empID);
        }

        public void TimeSheetRelease(TimeSheetModel timeSheet)
        {
            _managerRepository.TimeSheetRelease(timeSheet);
        }
    }
}
