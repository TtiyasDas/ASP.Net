using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentWebAppBusinessLayer.Business;
using System.Data;

namespace StudentWebApp.UserInterface
{
    public partial class Teacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTeacherLogIn_Click(object sender, EventArgs e)
        {

            TeacherBusiness teacherBusinessObj = new TeacherBusiness();
            DataTable dtLogin = teacherBusinessObj.TeacherLoginCheck(txtTeacherEmailLogIn.Text, txtTeacherPswLogIn.Text);
            if (dtLogin.Rows.Count > 0)
            {
                //Cookie
                //1. Persist Cookie-(not have expired time) 2.Non-Persist Cookie-(has expired time )
                //HttpCookie httpCookie = new HttpCookie("logininfo");
                //httpCookie["fname"] = dtLogin.Rows[0][0].ToString();
                //httpCookie["lname"] = dtLogin.Rows[0][1].ToString();
                //httpCookie["email"] = dtLogin.Rows[0][2].ToString();
                //httpCookie["mobile"] = dtLogin.Rows[0][3].ToString();
                //httpCookie.Expires.Add(new TimeSpan(0, 0, 20));
                //Response.Cookies.Add(httpCookie);

                //QueryString
                //Response.Redirect("Home.aspx?email=" + dtLogin.Rows[0][2].ToString()+"&fname="+ dtLogin.Rows[0][0].ToString());

                //session storage
                Application["teacherdetails"] = dtLogin;
                Application["TeacherEmail"] = dtLogin.Rows[0][2].ToString();
                Application["TeacherName"] = dtLogin.Rows[0][0].ToString();
                Response.Redirect("TeacherSignUp.aspx");


            }
            else
            {
                lblTeacherResult.Text = "Email id or password wrong!";
            }
        }
    }
}