using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_5_1_Button_Click : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            Response.Write("1.第N次執行Page_Load() " + DateTime.Now.ToLongTimeString() + "<br/><br/>");
        }
        else
        {
            Response.Write("1.程式會首先執行Page_Load()這一區塊 " + DateTime.Now.ToLongTimeString() + "<br/><br/>");
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        Response.Write("2.有輸入資料! "+DateTime.Now.ToLongTimeString()+ "<br/><br/>");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("3. 按下按鈕! "+DateTime.Now.ToLongTimeString()+ "<br/><br/>");
    }
}