using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace WebService97_42
{
    /// <summary>
    /// Summary description for RoomAvailability
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RoomAvailability : System.Web.Services.WebService
    {

        SqlConnection sqlCon = null;
        public SqlConnection GetConnection()
        {
            try
            {
                sqlCon = new SqlConnection(@"Data Source=DESKTOP-911ORN9\SQLEXPRESS;Initial Catalog=DB97_42;Integrated Security=True");
                sqlCon.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to Db" + ex);
            }
            return sqlCon;
        }
        [WebMethod]
        public DataSet FindRoomRoomCountry(string Country)
        {
            DataSet ds = new DataSet();
            try
            {
                GetConnection();
                SqlCommand cmd = new SqlCommand("Select * from Reservation where Country='" + Country + "'", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Stock");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error finding Room " + ex);
            }
            return ds;
        }
        [WebMethod]
        public DataSet FindRoomRoomId(string RoomId)
        {
            DataSet ds = new DataSet();
            try
            {
                GetConnection();
                SqlCommand cmd = new SqlCommand("Select * from Reservation where RoomId='" + RoomId + "'", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Stock");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error finding Room " + ex);
            }
            return ds;
        }
    }
}

