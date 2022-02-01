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
    public partial class BusDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            BusDBConnection busDBConnectionObj = new BusDBConnection();
            BusModel busModelObj = new BusModel();

            busModelObj.BusName = txtBusName.Text;
            busModelObj.BusNo = Convert.ToInt32(txtBusNo.Text);
            busModelObj.RouteNo = Convert.ToInt32(txtRouteNo.Text);
            busModelObj.DestinationArraivalTime = txtDestinationArrivalTime.Text;
            busModelObj.DestinationDepartureTime = txtDestinationDepartureTime.Text;

            string msg = busDBConnectionObj.InsertBus(busModelObj);
            lblResult.Text = msg;
            LoadData();
        }
        public void LoadData()
        {
            BusDBConnection busDBConnectionObj = new BusDBConnection();
            DataTable dtResult = busDBConnectionObj.SelectBus();
            gvResult.DataSource = dtResult;
            gvResult.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            BusDBConnection busDBConnectionObj = new BusDBConnection();
            string msg = busDBConnectionObj.DeleteBus(Convert.ToInt32(txtBusNo.Text));
            lblResult.Text = msg;

            LoadData();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            BusDBConnection busDBConnectionObj = new BusDBConnection();
            DataTable dtResult = busDBConnectionObj.EditBus(Convert.ToInt32(txtBusNo.Text));
            txtBusName.Text = dtResult.Rows[0][1].ToString();
            txtRouteNo.Text = dtResult.Rows[0][2].ToString();
            txtDestinationArrivalTime.Text = dtResult.Rows[0][3].ToString();
            txtDestinationDepartureTime.Text = dtResult.Rows[0][4].ToString();
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}