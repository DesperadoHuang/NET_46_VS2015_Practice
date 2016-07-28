using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch2_4_2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(Request["number"]);

        if (a>10)
        {
            Response.Write("number>10");
        }
        else
        {
            Response.Write("number<=10");
        }
    }
}