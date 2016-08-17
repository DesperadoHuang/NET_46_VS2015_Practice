using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_5_7_Button_UseSubmitBehavior : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("輸入的文字：" + TextBox1.Text);
        Button1.Text = "資料處理中...請稍後";
        Button1.Enabled = false;
    }
}