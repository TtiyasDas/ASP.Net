using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CityBusManagementBusiness;
using EntityLayer;
using CityBusManagementDataLayer;

namespace CityBusManagementSystemWebApp
{
    public partial class RouteManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            RouteDbConnection routeDbConnectionObj = new RouteDbConnection();
            RouteModel routeModelObj = new RouteModel();

            routeModelObj.RouteNo = Convert.ToInt32(txtRouteNo.Text);
            routeModelObj.NoOfStops = Convert.ToInt32(txtNoOfStops.Text);
            routeModelObj.FareStages = Convert.ToInt32(txtFareStages.Text);
            routeModelObj.Begin_Stop = txtBegStop.Text;
            routeModelObj.End_Stop = txtEndStop.Text;
            routeModelObj.Start_Time = txtStartTime.Text;
            routeModelObj.End_Time = txtEndTime.Text;

            string msg = routeDbConnectionObj.InsertRoute(routeModelObj);
            lblResult.Text = msg;
            LoadData();
        }
        public void LoadData()
        {
            RouteDbConnection routeDbConnectionObj = new RouteDbConnection();
            DataTable dtResult = routeDbConnectionObj.SelectTutorial();
            gvResult.DataSource = dtResult;
            gvResult.DataBind();
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            RouteDbConnection routeDbConnectionObj = new RouteDbConnection();
            string msg = routeDbConnectionObj.DeleteRoute(Convert.ToInt32(txtRouteNo.Text));
            lblResult.Text = msg;

            LoadData();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            RouteDbConnection routeDbConnectionObj = new RouteDbConnection();
            DataTable dtResult = routeDbConnectionObj.EditRoute(Convert.ToInt32(txtRouteNo.Text));
            txtNoOfStops.Text = dtResult.Rows[0][1].ToString();
            txtFareStages.Text = dtResult.Rows[0][2].ToString();
            txtBegStop.Text = dtResult.Rows[0][3].ToString();
            txtEndStop.Text = dtResult.Rows[0][4].ToString();
            txtStartTime.Text = dtResult.Rows[0][5].ToString();
            txtEndTime.Text = dtResult.Rows[0][6].ToString();
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}