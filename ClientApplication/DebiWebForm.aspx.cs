using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientApplication
{
    public partial class DebiWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

    

        protected void btnAdmin_Click1(object sender, EventArgs e)
        {
            Response.Redirect("LoginForm.aspx");
        }

        protected void btnCustomer_Click1(object sender, EventArgs e)
        {
            Response.Redirect("CustomerLoginWebForm.aspx");
        }
    }
}