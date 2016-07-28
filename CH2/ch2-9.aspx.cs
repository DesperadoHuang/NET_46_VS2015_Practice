using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch2_9 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        String strA = "ABCDEFG";
        Response.Write(strA.Length);//Lenght屬性：字串長度

        showLine();

        strA = strA.Replace("A", "B");//Replace("被替換字串","要換成的字串")，回傳替換完成的字串
        Response.Write(strA);

        showLine();





    }

    public void showLine()
    {
        Response.Write("<hr>");
    }
}