using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class admin_query : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|Datadirectory|\Database.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd, cmd1;
    protected void Page_Load(object sender, EventArgs e)
    {
        cmd = new SqlCommand("select * from user_query where status='waiting'", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        GridView2.DataSource = dt;
        GridView2.DataBind();

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        String id = GridView2.SelectedRow.Cells[1].Text;
        String no = GridView2.SelectedRow.Cells[2].Text;
        String dest = GridView2.SelectedRow.Cells[3].Text;
        Session["uname"] = id;
        Session["query"] = no;
        Session["cdate"] = dest;
        Response.Redirect("admin_query_1.aspx");

    }
}