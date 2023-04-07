using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ClientApplication
{
    public partial class RegistrationWebForm : System.Web.UI.Page
    {

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-911ORN9\SQLEXPRESS;Initial Catalog=DB97_42;Integrated Security=True");
        RegistrationServiceReference.RegistrationWebServiceasmxSoapClient obj = new RegistrationServiceReference.RegistrationWebServiceasmxSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistration_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into RegistrationTable values('"+ txtHotelId.Text+"','" + txtHotelName.Text+"','" + txtEmail.Text+"','" + txtAddress.Text+"','" + txtPhonenumber.Text+"','" + txtLocation.Text+"','" + txtPassword.Text+"','" + txtConfirmPassword.Text+"')";
            cmd.ExecuteNonQuery();
            Label1.Text = "Registration succeed!!!";
            cn.Close();
            
        }

        protected void txtHotelId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}