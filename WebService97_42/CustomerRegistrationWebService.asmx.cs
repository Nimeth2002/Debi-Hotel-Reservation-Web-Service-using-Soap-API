using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
namespace WebService97_42
{
    /// <summary>
    /// Summary description for CustomerRegistrationWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CustomerRegistrationWebService : System.Web.Services.WebService
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
        public string insertCustomer(string Name, string Email, string Address, string Phonenumber, string Password, string ConfirmPassword)
        {
            int noRecords = 0;

            try
            {
                GetConnection();
                SqlCommand cmd = new SqlCommand("insert into CustomerregistrationTable values ('" + Name + "','" + Email + "','" + Address + "','" + Phonenumber + "','" + Password + "','" + ConfirmPassword + "');", sqlCon);

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
