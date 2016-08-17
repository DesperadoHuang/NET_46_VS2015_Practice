using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_6_1_Button_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {      
        Response.Write("<br/>1. Click事件***Button的內建CommandArgument是...");
        Response.Write(Button1.CommandArgument);
    }

    protected void Button1_Command(object sender, CommandEventArgs e)
    {
        Response.Write("<br/>2. Command事件***Button的內建CommandArgument是...");
        Response.Write(e.CommandArgument);
    }
}