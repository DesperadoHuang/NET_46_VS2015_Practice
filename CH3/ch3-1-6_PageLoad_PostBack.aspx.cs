using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_1_6_PageLoad_PostBack : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            Label1.Text = (Convert.ToInt32(Label1.Text) + 1).ToString();
            Response.Write("網頁重新PostBack (回傳).....Page_Load事件....<br/><br/>");
        }
        else
        {
            Response.Write("網頁<b>第一次執行</b>....Page_Load事件...<br/><br/>");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("按下按鈕....觸發Button的Click事件...<br/><br/>");
    }
}