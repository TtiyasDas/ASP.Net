using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace CityBusManagementDataLayer
{
    public class BusDBConnection
    {
        string sqlConnectionStr = "Data Source=Tiyas;Initial Catalog=CityBusManagementDB;Integrated Security=True";
        public string InsertBus(BusModel busModelObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into BusDetails values('" + busModelObj.BusName + "'," + busModelObj.BusNo + "," + busModelObj.RouteNo + ",'" + busModelObj.DestinationArraivalTime + "','" + busModelObj.DestinationDepartureTime + "')", sqlConnectionStr);
            adp.Fill(dt);
            return "Bus Details Saved Successfully";
        }
        public string DeleteBus(int BusNo)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("delete from BusDetails where BusNo="+BusNo+"", sqlConnectionStr);
            adp.Fill(dt);
            return "Bus Details deleted Successfully";
        }
        public DataTable EditBus(int BusNo)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from BusDetails where BusNo=" + BusNo + "", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }
        public DataTable SelectBus()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from BusDetails", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }
    }
}
