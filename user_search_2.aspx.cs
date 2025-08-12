using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class user_search_2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["id"] as String;
        Label2.Text = Session["flower"] as String;
        Label3.Text = Session["price"] as String;
        Label4.Text = Session["desc"] as String;
        Label5.Text = Session["qt"] as String;

        String ss1 = Session["qt"] as String;
        int d = ((Convert.ToInt32(ss1)));
        String ss2 = Session["price"] as String;
        int d1 = ((Convert.ToInt32(ss2)));
        Label6.Text = "" + (d * d1);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String uname = Session["uname"] as string;
        con.Open();
        cmd = new SqlCommand("insert into user_purchased values('" + uname + "','" + Label1.Text + "','" + Label2.Text + "','" + Label3.Text + "','" + Label4.Text + "','" + Label5.Text + "','" + Label6.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','0','0')", con);
        cmd.ExecuteNonQuery();
        ScriptManager.RegisterStartupScript(this, this.GetType(),
"alert",
"alert('Purchased sucessfully');window.location ='user_home.aspx';",
true);
        // Response.Write("<Script> alert('Your details Are Saved!')</Script>");
        // Response.Redirect("user.aspx");
        con.Close();
    }
}