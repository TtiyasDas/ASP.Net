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
            var studentList = _studentDbContext.Student.ToList();
            return View(studentList);
        }
        public IActionResult StudentEntity()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StudentEntity(Student student)
        {
            _studentDbContext.Student.Add(student);
            _studentDbContext.SaveChanges();
            ViewBag.message = "Student Details Saved Successfully";
            return View();
        }
        public IActionResult EditStudent(int Roll)
        {
            return View();
        }
        public IActionResult DeleteStudent(int Roll)
        {
            return View();
        }

    }
}
