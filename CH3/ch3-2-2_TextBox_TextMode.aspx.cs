using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_2_2_TextBox_TextMode : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        textBox_Color.TextMode = TextBoxMode.Color;
        textBox_DateTime.TextMode = TextBoxMode.DateTime;
        textBox_Email.TextMode = TextBoxMode.Email;
        textBox_URL.TextMode = TextBoxMode.Url;
        textBox_Range.TextMode = TextBoxMode.Range;
    }
}