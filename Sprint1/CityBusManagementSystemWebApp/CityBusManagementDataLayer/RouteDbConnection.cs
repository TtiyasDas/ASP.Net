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
    public class RouteDbConnection
    {
        string sqlConnectionStr = "Data Source=Tiyas;Initial Catalog=CityBusManagementDB; Integrated Security=True";
        public string InsertRoute(RouteModel routeModelObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into RouteManagementTable values(" + routeModelObj.RouteNo + "," + routeModelObj.NoOfStops + "," + routeModelObj.FareStages +",'" + routeModelObj.Begin_Stop + "','" + routeModelObj.End_Stop +"','" + routeModelObj.Start_Time + "','" + routeModelObj.End_Time+"')", sqlConnectionStr);
            adp.Fill(dt);
            return "Route Details Save Successfully";
        }
        public string DeleteRoute(int RouteNo)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("delete from RouteManagementTable where RouteNo=" + RouteNo + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Route No " + RouteNo + " details deleted successfully";
        }
        public DataTable EditRoute(int RouteNo)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from RouteManagementTable where RouteNo=" + RouteNo + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
        public DataTable SelectTutorial()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from RouteManagementTable", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }
    }
}
