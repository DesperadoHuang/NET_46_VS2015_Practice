using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch2_3_5_Response_BufferOutput : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.BufferOutput = true;//開啟緩衝區

        Response.Write("第一次寫入緩衝區");

        Response.Clear();//清除緩衝區

        Response.Write("第二次寫入緩衝區");

        Response.Flush();//強制送出緩衝區資料
    }
}