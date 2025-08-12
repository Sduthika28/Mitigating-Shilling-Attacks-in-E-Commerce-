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
public partial class user_search : System.Web.UI.Page
{
    string s;


    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        cmd = new SqlCommand("select * from product_details", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        // GridView1.DataSource = dt;
        //GridView1.DataBind();
        gvImages.DataSource = dt;

        gvImages.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String pname = TextBox1.Text;
        cmd = new SqlCommand("select * from product_details where product_name='"+pname+"'", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        // GridView1.DataSource = dt;
        //GridView1.DataBind();
        gvImages.DataSource = dt;

        gvImages.DataBind();
    }
    protected void gvImages_SelectedIndexChanged(object sender, EventArgs e)
    {
        String h = gvImages.SelectedRow.Cells[1].Text;
        String i = gvImages.SelectedRow.Cells[2].Text;
        String qty = gvImages.SelectedRow.Cells[3].Text;
        String qty1 = gvImages.SelectedRow.Cells[4].Text;

        Session["id"] = h;
        Session["flower"] = i;
        Session["price"] = qty;
        Session["desc"] = qty1;

        Response.Redirect("user_search_1.aspx");
    }
}