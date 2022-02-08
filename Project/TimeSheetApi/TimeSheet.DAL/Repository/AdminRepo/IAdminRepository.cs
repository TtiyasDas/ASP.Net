﻿using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Entity.Models;

namespace TimeSheet.DAL.Repository.AdminRepo
{
    public interface IAdminRepository
    {
        #region Employee
        void AddEmployee(Employee employee);
        Employee UpdateEmployee(int EmpID);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int EmpID);
        Employee GetEmployeeByID(int EmpID);
        IEnumerable<Employee> GetEmployees();
        Employee AssignManager(int EmpID);
        void AssignManager(Employee employee);
        #endregion

        #region Project

        void AddProject(Project project);
        void UpdateProject(Project project);
        void DeleteProject(int ProjectID);
        Project GetProjectByID(int ProjectID);
        IEnumerable<Project> GetProjects();

        #endregion

    }
}
