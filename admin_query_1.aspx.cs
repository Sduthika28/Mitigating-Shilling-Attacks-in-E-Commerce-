using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
public partial class admin_query_1 : System.Web.UI.Page
{
    String sts = "0";
    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        String uname = Session["uname"] as string;
         String query=Session["query"]as string;
         String cdate= Session["cdate"]as string;
         Label1.Text = uname;
         Label2.Text = query;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        String cdate= Session["cdate"]as string;
        cmd = new SqlCommand("update user_query set response='" + TextBox1.Text
            

            + "',status='Response' where uname='" + Label1.Text + "' and cdate='"+cdate+"'", con);
        cmd.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(),
"alert",
"alert('Update Success');window.location ='admin_query.aspx';",
true);
        String resp = TextBox1.Text;
    }
}