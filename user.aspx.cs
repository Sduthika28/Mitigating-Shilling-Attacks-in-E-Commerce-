using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class user : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|Datadirectory|\Database.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        Session["uname"] = TextBox1.Text;
        cmd = new SqlCommand("select * from user_details  where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "' ", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {

            ScriptManager.RegisterStartupScript(this, this.GetType(),
"alert",
"window.location ='user_home.aspx';alert('Login Success');",
true);
        }
        else
        {
            Response.Write("<Script> alert('Login Failed') </Script>");
        }
        con.Close();
    }
}