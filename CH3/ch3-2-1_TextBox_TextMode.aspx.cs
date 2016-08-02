using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_3_1_TextBox_TextMode : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.TextMode = TextBoxMode.MultiLine;
        TextBox1.Text = "動態修改後的「值」";

        TextBox1.BackColor = System.Drawing.Color.AliceBlue;
    }
}