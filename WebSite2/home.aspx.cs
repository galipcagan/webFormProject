using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class home : System.Web.UI.Page
{
    protected void defaultEventMethod(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");

    }
    /* Not using at the moment
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    */
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}