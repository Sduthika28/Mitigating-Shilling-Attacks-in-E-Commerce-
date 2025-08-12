using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "admin" && TextBox2.Text == "admin")
        {

            ScriptManager.RegisterStartupScript(this, this.GetType(),
"alert",
"alert('Admin Login sucessfully');window.location ='admin_home.aspx';",
true);
        }
        else
        {
            Response.Write("<script language=javascript>alert('UserName or Password Incorrect!')</script>");

        }
    }
}