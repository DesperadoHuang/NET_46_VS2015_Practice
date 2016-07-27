using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch2_3_4_Response_End : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.End();//程式在此中斷，以下程式碼將無法被執行
        
        Response.Redirect("http://www.edamall.com.tw/");
    }
}