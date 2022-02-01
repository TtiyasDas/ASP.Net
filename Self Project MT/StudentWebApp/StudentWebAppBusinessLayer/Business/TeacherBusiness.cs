using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentWebAppEntityLayer.Models;
using StudentWebAppDataLayer.Data_Connection;
using System.Data;

namespace StudentWebAppBusinessLayer.Business
{
    public class TeacherBusiness
    {
        public string InsertTeacher(TeacherModel teacherModelObj)
        {
            TeacherDBConnection teacherDBConnection = new TeacherDBConnection();
            string msg = teacherDBConnection.InsertTeacher(teacherModelObj);
            return msg;
        }
        public string UpdateTeacher(TeacherModel teacherModelObj)
        {
            TeacherDBConnection teacherDBConnection = new TeacherDBConnection();
            string msg = teacherDBConnection.UpdateTeacher(teacherModelObj);
            return msg;
        }
        public DataTable EditTeacherById(int TeacherID)
        {
            TeacherDBConnection teacherDBConnection = new TeacherDBConnection();
            DataTable dt = teacherDBConnection.EditTeacherById(TeacherID);
            return dt;
        }
        public DataTable TeacherLoginCheck(string TeacherEmail, string TeacherPsw)
        {
            TeacherDBConnection teacherDBConnectionObj = new TeacherDBConnection();
            DataTable dt = teacherDBConnectionObj.TeacherLoginCheck(TeacherEmail, TeacherPsw);
            return dt;
        }
    }
}
