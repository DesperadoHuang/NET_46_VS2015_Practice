using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_4_5_TextBox_Click : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Attributes["onclick"] = ClientScript.GetPostBackEventReference(Button1, null);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("<big><font color=darkgreen>您剛剛做了 Click動作 --</font></big>"+DateTime.Now.ToLongTimeString());
    }
}