using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace TimeSheet.DAL.Data
{
     public class TimeSheetDbContext :DbContext
    {
        public TimeSheetDbContext(DbContextOptions<TimeSheetDbContext> options):base(options)
        {

        }
        public DbSet<Project> project { get; set; }
        public DbSet<Employee> employee { get; set; }
        public DbSet<TimeSheetModel> timeSheet { get; set; }
    }
}
