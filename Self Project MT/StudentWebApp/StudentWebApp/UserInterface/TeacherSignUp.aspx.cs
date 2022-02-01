using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentWebAppBusinessLayer.Business;
using StudentWebAppEntityLayer.Models;
using System.Data;

namespace StudentWebApp.UserInterface
{
    public partial class TeacherSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaveSignUp_Click(object sender, EventArgs e)
        {
                TeacherBusiness teacherBussinessObj = new TeacherBusiness();
                TeacherModel teacherModelObj = new TeacherModel();

                teacherModelObj.TeacherID = Convert.ToInt32(txtTeacherIDSignUp.Text);
                teacherModelObj.TeacherName = txtTeacherNameSignUp.Text;
                teacherModelObj.TeacherEmail = txtTeacherEmailSignUp.Text;
                teacherModelObj.TeacherPsw = txtTeacherPswSignUp.Text;

                string msg = teacherBussinessObj.InsertTeacher(teacherModelObj);
             
        }

        protected void btnTeacherUpdateSignUp_Click(object sender, EventArgs e)
        {
            TeacherBusiness teacherBusinessObj = new TeacherBusiness();
            TeacherModel teacherModelObj = new TeacherModel();

            teacherModelObj.TeacherID = Convert.ToInt32(txtTeacherIDSignUp.Text);
            teacherModelObj.TeacherName = txtTeacherNameSignUp.Text;
            teacherModelObj.TeacherEmail= txtTeacherEmailSignUp.Text;
            teacherModelObj.TeacherPsw = txtTeacherPswSignUp.Text;

            string msg = teacherBusinessObj.UpdateTeacher(teacherModelObj);
            TeacherlblResult.Text = msg;
        }

        protected void btnTeacherEditSignUp_Click(object sender, EventArgs e)
        {
            TeacherBusiness teacherBusinessObj = new TeacherBusiness();
            DataTable dtResult = teacherBusinessObj.EditTeacherById(Convert.ToInt32(txtTeacherIDSignUp.Text));
            txtTeacherNameSignUp.Text = dtResult.Rows[0][1].ToString();
            txtTeacherEmailSignUp.Text = dtResult.Rows[0][2].ToString();
            txtTeacherPswSignUp.Text = dtResult.Rows[0][3].ToString();
        }
    }
}