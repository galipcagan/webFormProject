using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void registerEventMethod(object sender, EventArgs e) {
        if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || emailTextBox.Text == "" || phoneTextBox.Text == "")
        {

            Response.Redirect("default.aspx"); //get refresh of the page untill all fields are full
        }

        try
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
            con.Open();
            string insert = "insert contacts (first, last, email, phone) values(@first, @last, @email, @phone)";
            SqlCommand comd = new SqlCommand(insert, con);
            comd.Parameters.AddWithValue("@first", firstNameTextBox.Text);
            comd.Parameters.AddWithValue("@last", lastNameTextBox.Text);
            comd.Parameters.AddWithValue("@email", emailTextBox.Text);
            comd.Parameters.AddWithValue("@phone", phoneTextBox.Text);
            comd.ExecuteNonQuery();

            Response.Redirect("home.aspx");
            con.Close();
        }

        catch (Exception ex) {
            Response.Write(ex);
        }


    }
    /* Not using it at the moment
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
    */
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("home.aspx");
    }
}