﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TimeSheet.Entity.Models;

namespace TimeSheet.UI.Controllers
{
    public class ManagerController : Controller
    {
        private IConfiguration _configuration;
        public ManagerController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IActionResult> GetEmployees(int MgrID)
        {
            IEnumerable<Employee> employeeResult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "Manager/GetEmployees?MgrID=" + MgrID;
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        employeeResult = JsonConvert.DeserializeObject<IEnumerable<Employee>>(result);
                    }
                }
            }
            return View(employeeResult);
        }

        public async Task<IActionResult> AllocateProject(int EmpID)
        {
            Employee employeeResult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "Manager/AllocateProject?EmpID=" + EmpID;
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        employeeResult = JsonConvert.DeserializeObject<Employee>(result);
                    }
                }
            }
            return View(employeeResult);
        }

        [HttpPost]
        public async Task<IActionResult> AllocateProject(Employee employee)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "Manager/AllocateProject";
                using (var response = await client.PutAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Project Allocated successfully!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();

        }

        public async Task<IActionResult> ChangeEmpPsw(int EmpID)
        {
            Employee employeeResult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "Manager/ChangeEmpPsw?EmpID=" + EmpID;
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        employeeResult = JsonConvert.DeserializeObject<Employee>(result);
                    }
                }
            }
            return View(employeeResult);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeEmpPsw(Employee employee)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "Manager/ChangeEmpPsw";
                using (var response = await client.PutAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Password Changed successfully!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();

        }


        public async Task<IActionResult> GetTimeSheetByID(int EmpID)
        {
            TimeSheetModel timeSheetResult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "Manager/GetTimeSheetByID?EmpID=" + EmpID;
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        timeSheetResult = JsonConvert.DeserializeObject<TimeSheetModel>(result);
                    }
                }
            }
            return View(timeSheetResult);
        }

        public async Task<IActionResult> TimeSheetRelease(int TimeSheetID)
        {
            TimeSheetModel timeSheetResult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "Manager/TimeSheetRelease?TimeSheetID=" + TimeSheetID;
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        timeSheetResult = JsonConvert.DeserializeObject<TimeSheetModel>(result);
                    }
                }
            }
            return View(timeSheetResult);

        }

        [HttpPost]
        public async Task<IActionResult> TimeSheetRelease(TimeSheetModel timeSheet)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(timeSheet), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "Manager/TimeSheetRelease";
                using (var response = await client.PutAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "TimeSheet Released successfully!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();

        }

    }
}
