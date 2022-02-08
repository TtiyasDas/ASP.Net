﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheet.BAL.Services;
using TimeSheet.Entity.Models;

namespace TimeSheetApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeServices _employeeServices;
        public EmployeeController(EmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
        }

        [HttpPost("AddTimeSheet")]
        public IActionResult AddTimeSheet([FromBody] TimeSheetModel timeSheet)
        {
            _employeeServices.AddTimeSheet(timeSheet);
            return Ok("TimeSheet Added successfully!!");
        }

        [HttpDelete("DeleteTimeSheet")]
        public IActionResult DeleteTimeSheet(int TimeSheetID)
        {
            _employeeServices.DeleteTimeSheet(TimeSheetID);
            return Ok("TimeSheet Deleted successfully!!");
        }

        [HttpPut("UpdateTimeSheet")]
        public IActionResult UpdateTimeSheet([FromBody] TimeSheetModel timeSheet)
        {
            _employeeServices.UpdateTimeSheet(timeSheet);
            return Ok("TimeSheet Updated successfully!!");
        }
    }
}
