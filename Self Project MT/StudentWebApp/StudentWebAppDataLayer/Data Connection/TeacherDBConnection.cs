using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using StudentWebAppEntityLayer.Models;
using System.Data.SqlClient;

namespace StudentWebAppDataLayer.Data_Connection
{
    public class TeacherDBConnection
    {
        string sqlConnectionStr = "Data Source=TIYAS;Initial Catalog=StudentDB;Integrated Security=True";
        public string InsertTeacher(TeacherModel teacherModelObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into Teacher values("+teacherModelObj.TeacherID+",'"+teacherModelObj.TeacherName+"','"+teacherModelObj.TeacherEmail+"','"+teacherModelObj.TeacherPsw+"')", sqlConnectionObj);
            adp.Fill(dt);
            return "Teacher details saved successfully";
        }
        public string UpdateTeacher(TeacherModel teacherModelObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            //SqlCommand sqlCommandObj = new SqlCommand("update Tutorial set tutorialname='" + tutorialModelObj.TutorialName + "' , tutorialdesc='" + tutorialModelObj.TutorialDesc + "' , published=" + tutorialModelObj.Published + " where tutorialid=" + tutorialModelObj.TutorialId + "", sqlConnectionObj);
            //sqlConnectionObj.Open();
            //sqlCommandObj.ExecuteNonQuery();
            //sqlConnectionObj.Close();
            #region disconnected approach
            SqlDataAdapter adp = new SqlDataAdapter("update Teacher set TeacherName='" + teacherModelObj.TeacherName + "' , TeacherEmail='" + teacherModelObj.TeacherEmail + "' , TeacherPsw='" + teacherModelObj.TeacherPsw +"' where TeacherID=" + teacherModelObj.TeacherID + "", sqlConnectionObj);
            adp.Fill(dt);
            #endregion
            return "Teacher ID " + teacherModelObj.TeacherID + " Teacher's Details updated successfully";
        }
        public DataTable EditTeacherById(int TeacherID)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from Teacher where TeacherID=" + TeacherID + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
        public DataTable TeacherLoginCheck(string TeacherEmail, string TeacherPsw)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select TeacherID,TeacherName,TeacherEmail from Teacher where TeacherEmail='" + TeacherEmail + "' and TeacherPsw='" + TeacherPsw + "'", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }
    }
}
