using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_4_4_TextBox_DefaultValue_TextChanged : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            TextBox1.Text = "===Page_Load事件，第N次給予的預設值===" + DateTime.Now.ToLongTimeString();
        }
        else
        {
            TextBox1.Text = "Page_Load事件，第一次給予的預設值" + DateTime.Now.ToLongTimeString();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "***Button給予的預設值***" + DateTime.Now.ToLongTimeString();
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        Label1.Text = "***TextBox1_TextChanded觸發事件***" + DateTime.Now.ToLongTimeString();
    }
}