using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientApplication
{
    public partial class RoomAvailability : System.Web.UI.Page
    {
        RoomAvailbilityServiceReference.RoomAvailabilitySoapClient obj = new RoomAvailbilityServiceReference.RoomAvailabilitySoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            GridView1.DataSource = obj.FindRoomRoomCountry(txtSearch.Text);
            GridView1.DataSource = obj.FindRoomRoomId(txtSearch.Text);
        }
    }
}