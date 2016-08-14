using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_4_3_TextBox_Password_Strength : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        int passwordStrength = 0;

        if (TextBox1.Text.Length > 3)
        {
            passwordStrength++;
        }

        string[] allowedNumber = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        for (int i = 0; i < allowedNumber.Length; i++)
        {
            if (TextBox1.Text.IndexOf(allowedNumber[i]) >= 0)
            {
                passwordStrength++;
                break;
            }
        }

        string[] allowedSignal = { "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")" };
        for (int i = 0; i < allowedNumber.Length; i++)
        {
            if (TextBox1.Text.IndexOf(allowedSignal[i]) >= 0)
            {
                passwordStrength++;
                break;
            }
        }
        switch (passwordStrength)
        {
            case 0:
                Response.Write("密碼強度不足，必須三個字元以上");
                break;
            case 1:
                Image1.ImageUrl = "image\\Password_01.jpg";
                break;
            case 2:
                Image1.ImageUrl = "image\\Password_02.jpg";
                break;
            case 3:
                Image1.ImageUrl = "image\\Password_03.jpg";
                break;

            default:
                break;
        }
    }
}