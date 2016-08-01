using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_1_4_PageLoad_IsPostBack : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)//判斷是否已觸發過PostBack，true表示不是第一次開啟此網頁，false表示第一次開啟此網頁
        {
            Label1.Text = (Convert.ToInt32(Label1.Text) + 1).ToString();
        }
        else
        {
           
        }
    }
}