using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace StudentMVC.Models
{
    public class Student
        {
            [Key]
            public int Roll { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Psw { get; set; }
        }
}
