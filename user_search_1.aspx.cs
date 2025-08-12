using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class user_search_1 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["id"] as String;
        Label2.Text = Session["flower"] as String;
        Label3.Text = Session["price"] as String;
        Label4.Text = Session["desc"] as String;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["qt"] = TextBox1.Text;

        Response.Redirect("user_search_2.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("user_search_1_review.aspx");
    }
}