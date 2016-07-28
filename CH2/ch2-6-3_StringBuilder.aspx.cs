using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class ch2_6_3_StringBuilder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string text = null;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < 100; i++)
        {
            sb.Append(i.ToString() + "<br>");//使用Append()方法來做字串相連
        }

        Response.Write(sb.ToString());
    }
}