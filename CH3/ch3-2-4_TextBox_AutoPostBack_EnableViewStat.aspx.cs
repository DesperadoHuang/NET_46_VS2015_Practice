using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_2_4_TextBox_AutoPostBack_EnableViewStat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            Response.Write("再度執行此網頁Page_Load......<br/>");
        }
        else
        {
        Response.Write("第一執行此網頁Page_Load......<br/>");
        }
    }

    protected void textBox1OnTextChanged(object sender, EventArgs e)
    {
        Response.Write("TextBox1OnTextChanged....<br/>");
    }

    protected void TextBox2OnTextChanged(object sender, EventArgs e)
    {
        Response.Write("TextBox2OnTextChanged.....<br/>");
    }
}