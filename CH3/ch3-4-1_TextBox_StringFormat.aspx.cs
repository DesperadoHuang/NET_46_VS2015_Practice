using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_4_1_TextBox_StringFormat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btSubmit_Click(object sender, EventArgs e)
    {
        int sum = Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox3.Text);

        Label1.Text = String.Format("{0:c}", sum);
    }
}