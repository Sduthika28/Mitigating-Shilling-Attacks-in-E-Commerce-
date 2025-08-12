using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class user_search_1_review : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|Datadirectory|\Database.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=true");
    SqlCommand cmd, cmd1;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        String pid= Session["id"] as string;
        String pname = Session["flower"] as string;
        String uname = Session["uname"] as string;
        con.Open();
        cmd = new SqlCommand("select * from user_purchased where uname='" + uname + "' and pid='"+pid+"'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        int aa = 0;
        if (dr.Read())
        {

            aa = aa + 1;

        }
        String review = "Fake";
        if (aa > 0)
        {
            review = "True";
        }
        cmd1 = new SqlCommand("insert into user_review values('" + uname + "','" + pid + "','" + pname + "','" + TextBox1.Text + "','"+review+"','0')", con);
        cmd1.ExecuteNonQuery();
        ScriptManager.RegisterStartupScript(this, this.GetType(),
"alert",
"alert('Feedback Send sucessfully');window.location ='user_home.aspx';",
true);
        con.Close();
    }
}