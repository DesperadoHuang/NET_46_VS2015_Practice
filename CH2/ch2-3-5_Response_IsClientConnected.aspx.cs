using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch2_3_5_Response_IsClientConnected : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Response.IsClientConnected)
        {
            Response.Write("連線中....");
        }
        else
        {
            Response.Write("已離線....");
        }
    }
}