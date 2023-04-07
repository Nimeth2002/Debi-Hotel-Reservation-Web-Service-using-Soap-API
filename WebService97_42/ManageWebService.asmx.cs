using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
namespace WebService97_42
{
    /// <summary>
    /// Summary description for ManageWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ManageWebService : System.Web.Services.WebService
    {
        SqlConnection sqlCon = null;
        public SqlConnection GetConnection()
        {
            try
            {
                sqlCon = new SqlConnection("data source=10.0.0.4;initial catalog=DB97_SOC;user id=hnd;password=hnd;");
                sqlCon.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to Db" + ex);

            }
            return sqlCon;
        }
        [WebMethod]
        public string AddRoom(string RoomId, string RoomType, string Country, string Price)
        {
            int noRecords = 0;

            try
            {
                GetConnection();
                SqlCommand cmd = new SqlCommand("insert into Reservation values ('" + RoomId + "','" + RoomType + "','" + Country + "');", sqlCon);

                noRecords = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return noRecords.ToString();
        }

    }
}