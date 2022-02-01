using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentMVC.Models;

namespace StudentMVC.Controllers
{
    public class StudentController : Controller
    {
        StudentDbContext _studentDbContext;
        public StudentController(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StudentEntity()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StudentEntity(Student student)
        {
            return View();
        }

    }
}
