using System;
using System.Data.SqlClient;


namespace ClientApplication
{
    public partial class LoginForm : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-911ORN9\SQLEXPRESS;Initial Catalog=DB97_42;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Username,Pass from LoginTable where Username ='" + txtUsername.Text + "' and Pass = '" + txtPassword.Text + "' ", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["id"] = txtUsername.Text;
                Response.Redirect("Manage.aspx");
            }
            else
            {
                Response.Write("Username or password is incorect. Try again !!! ");
            }

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrationWebForm.aspx");
        }
    }
}