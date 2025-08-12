using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class user_query : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String uname=Session["uname"]as string;
        String cdate = DateTime.Now.ToString();
        con.Open();
        cmd = new SqlCommand("insert into user_query values('" + uname + "','" + TextBox1.Text + "','"+cdate+"','-','waiting')", con);
        cmd.ExecuteNonQuery();
        ScriptManager.RegisterStartupScript(this, this.GetType(),
"alert",
"alert('Request send sucessfully');window.location ='user_home.aspx';",
true);
        // Response.Write("<Script> alert('Your details Are Saved!')</Script>");
        // Response.Redirect("user.aspx");
        con.Close();
    }
}