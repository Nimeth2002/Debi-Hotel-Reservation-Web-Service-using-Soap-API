using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ClientApplication
{
  
    public partial class CustomerLoginWebForm : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-911ORN9\SQLEXPRESS;Initial Catalog=DB97_42;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Username,Password from CustomerLogin where Username ='" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "' ", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["id"] = txtUsername.Text;
                Response.Redirect("RoomAvailability.aspx");
            }
            else
            {
                Response.Write("Username or password is incorect. Try again !!! ");
            }
        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerRegistrationForm.aspx");
        }
    }
}