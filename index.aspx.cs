using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;


public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\anurag\Documents\Visual Studio 2010\WebSites\Nimap Task\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert into product values(@1,@2,@3,@4)";
        cmd.Connection = con;
        cmd.Parameters.AddWithValue("@1", TextBox1.Text);
        cmd.Parameters.AddWithValue("@2", TextBox2.Text);
        cmd.Parameters.AddWithValue("@3", TextBox3.Text);
        cmd.Parameters.AddWithValue("@4", TextBox4.Text);
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
          {
             Label5.Text = "Record Saved...!!";
             Response.Redirect("viewdata.aspx");
          }
         else
           {
             Label5.Text = "Errroorrr....!!";
           }
       }
   }