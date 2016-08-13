using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_4_2_TextBox_StringFormat_2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        int result = Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox3.Text);

        Label1.Text = string.Format("{0:C}", result);
    }
}