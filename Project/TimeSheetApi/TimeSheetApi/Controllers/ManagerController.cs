using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheet.Entity.Models;
using TimeSheet.BAL.Services;

namespace TimeSheetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private ManagerServices _managerServices;
        public ManagerController(ManagerServices managerServices)
        {
            _managerServices = managerServices;
        }

        [HttpPut("AllocateProject")]
        public IActionResult AllocateProject([FromBody] Employee employee)
        {
            _managerServices.AllocateProject(employee);
            return Ok("Project Allocated successfully!!");
        }

        [HttpPut("ChangeEmpPsw")]
        public IActionResult ChangeEmpPsw([FromBody] Employee employee)
        {
            _managerServices.ChangeEmpPsw(employee);
            return Ok("Password Changed successfully!!");
        }

        [HttpGet("GetEmployees")]
        public IEnumerable<Employee> GetEmployees(int MgrID)
        {
            return _managerServices.GetEmployees(MgrID);
        }

        [HttpGet("GetTimeSheetByID")]
        public TimeSheetModel GetTimeSheetByID(int EmpID)
        {
            return _managerServices.GetTimeSheetByID(EmpID);
        }

        [HttpPut("TimeSheetRelease")]
        public IActionResult TimeSheetRelease([FromBody] TimeSheetModel timeSheet)
        {
            _managerServices.TimeSheetRelease(timeSheet);
            return Ok("TimeSheet Released successfully!!");
        }
    }
}
