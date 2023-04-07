using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace ClientApplication
{
    
    public partial class CustomerRegistrationForm : System.Web.UI.Page
    {
        CustomerRegistrationServiceReference.CustomerRegistrationWebServiceSoapClient obj = new CustomerRegistrationServiceReference.CustomerRegistrationWebServiceSoapClient();
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-911ORN9\SQLEXPRESS;Initial Catalog=DB97_42;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistration_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into CustomerregistrationTable values('" + txtName.Text + "','" + txtEmail1.Text + "','" + txtAddress1.Text + "','" + txtPhonenumber1.Text + "','" + txtPassword1.Text + "','" + txtConfirmPassword1.Text + "')";
            cmd.ExecuteNonQuery();
            Label1.Text = "Registration Succeed!!!";
            cn.Close();
        }
    }
}