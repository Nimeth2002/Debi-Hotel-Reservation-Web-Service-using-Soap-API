using System;
using System.Data.SqlClient;
using System.Web.Services;
namespace WebService97_42
{
    /// <summary>
    /// Summary description for RegistrationWebServiceasmx
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RegistrationWebServiceasmx : System.Web.Services.WebService
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
        public string AutoHotelId()
        {
            string HotelId = null;
            try
            {
                GetConnection();
                SqlCommand cmd = new SqlCommand("Select HotelId from RegistrationTable", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                string id = "";
                bool records = dr.HasRows; //T
                if (records)
                {
                    while (dr.Read())//F
                    {
                        id = dr[0].ToString();//C003
                    }

                    string idString = id.Substring(1);//003
                    int CTR = Int32.Parse(idString); //3
                    if (CTR >= 1 && CTR < 9)
                    {
                        CTR = CTR + 1;//4
                        HotelId = "H00" + CTR;//C004
                    }
                    else if (CTR >= 10 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        HotelId = "H0" + CTR;
                    }
                    else if (CTR > 99)
                    {
                        CTR = CTR + 1;
                        HotelId = "H" + CTR;
                    }
                }
                else
                {
                    HotelId = "H001";
                }
                dr.Close();
            }
            catch (Exception e1)
            {
                HotelId = e1.ToString();
            }
            return HotelId;
        }
        [WebMethod]
        public string insertHotel(string HotelId, string HotelName, string Email, string Address, string Phonenumber, string Location, string Password, string ConfirmPassword)
        {
            int noRecords = 0;

            try
            {
                GetConnection();
                SqlCommand cmd = new SqlCommand("insert into RegistrationTable values ('" + HotelId + "','" + HotelName + "','" + Email + "','" + Address + "','" + Phonenumber + "','" + Location + "','" + Password + "','" + ConfirmPassword + "');", sqlCon);

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
