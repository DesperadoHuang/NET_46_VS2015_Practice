﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch2_7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int i = 1;
        while (i<=100)
        {
            Response.Write("a"+i);
            Response.Write("<br>");
            i = i + 1;
        }
    }
}