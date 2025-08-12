using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
public partial class admin_add_product : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
    SqlCommand cmd;
    int n;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("select * from product_details order by id ASC", con);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            n = Convert.ToInt32(dr["id"].ToString());

        }
        dr.Close();

        int j = 1;
        int k = j + n;



        string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
        FileUpload1.PostedFile.SaveAs(Server.MapPath("~/img/") + fileName);




        string ss = "~/img/" + fileName;



        cmd = new SqlCommand("insert into product_details values('" + k + "','" + TextBox1.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + fileName + "','" + ss + "','0','0')", con);
        cmd.ExecuteNonQuery();
        ScriptManager.RegisterStartupScript(this, this.GetType(),
"alert",
"alert('Add sucessfully');window.location ='admin_home.aspx';",
true);


        con.Close();
    }
}