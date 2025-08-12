using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Configuration;
public partial class admin_booking : System.Web.UI.Page
{
    string s;


    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        cmd = new SqlCommand("select uname,pid,product,price,description,quantity,total from user_purchased", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        // GridView1.DataSource = dt;
        //GridView1.DataBind();
        GridView1.DataSource = dt;

        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        String h = GridView1.SelectedRow.Cells[1].Text;
        String i = GridView1.SelectedRow.Cells[2].Text;
        String qty = GridView1.SelectedRow.Cells[3].Text;
        String qty1 = GridView1.SelectedRow.Cells[4].Text;

        Session["id"] = h;
        Session["flower"] = i;
        Session["price"] = qty;
        Session["desc"] = qty1;

        Response.Redirect("admin_booking_1.aspx");
    }
}