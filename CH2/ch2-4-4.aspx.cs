using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch2_4_4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(Request["number"]);

        if (a > 3)
        {
            Response.Write("輸入範圍1-3");
        }
        else
        {
            if (a == 1)
            {
                Response.Redirect("http://www.edamall.com.tw/");
            }
            else if (a == 2)
            {
                Response.Redirect("http://www.google.com.tw");
            }
            else if (a == 3)
            {
                Response.Redirect("http://www.yahoo.com.tw");
            }
        }
    }
}