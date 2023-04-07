using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace ClientApplication
{
    public partial class Manage : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-911ORN9\SQLEXPRESS;Initial Catalog=DB97_42;Integrated Security=True");
        ManageServiceReference.ManageWebServiceSoapClient obj = new ManageServiceReference.ManageWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into Reservation values('" + txtRoomId.Text + "','" + txtRoomType.Text + "','" + txtCountry.Text + "','" + txtPrice.Text + "')";
            cmd.ExecuteNonQuery();
            cn.Close();

            Label1.Text = "Successfully Details added to the database";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (cn.State==System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }

            SqlCommand cmd = new SqlCommand("Delete from Reservation where RoomId='" + txtRoomId.Text + "'", cn);
            int i = cmd.ExecuteNonQuery();
            if (i>0)
            {
                Response.Write("Successfully deleted!!!");
            }
            else
            {
                Response.Write("Error deleting record!!!");
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("Update Reservation set RoomId='"+txtRoomId.Text+ "',RoomType='" + txtRoomType.Text + "',Country='" + txtCountry.Text + "',Pric'" + txtPrice.Text + "'where RoomId='" + txtRoomId.Text + "'",cn);
            if(cmd.ExecuteNonQuery()>0)
            {
                Response.Write("Updated successfully !!!");
            }
            else
            {
                Response.Write("Error while updating");
            }
            cn.Close();
        }
    }
}