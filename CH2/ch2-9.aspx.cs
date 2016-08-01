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

        String s1 = "The quick fox jumps over lazy dog";
        String s2 = "fox";
        Boolean b = s1.Contains(s2);//字串是否在內，如果有則回傳true

        int i = s1.IndexOf(s2);//判斷字串是否在內，如果有則回傳字串所在的位置，沒有則回傳-1

        Response.Write("b=" + b + " i=" + i);

        showLine();

        String words = "This is a book, :with: punctuation. @中文 我愛你";

        //將字串切割以後轉成陣列
        String[] resultArray = words.Split(' ');

        foreach (String s in resultArray)
        {
            Response.Write("<br>" + s);
        }

        showLine();

        String words2 = "This is a list of words.";
        String strResult = words2.Substring(5,10);//找出字串的第幾個字至第幾個字

        Response.Write(strResult);

        showLine();

        String str1 = words2.ToUpper();//將字串全部轉為大寫
        Response.Write(str1);

        showLine();

        String str2 = words2.ToLower();//將字串全部轉為小寫
        Response.Write(str2);

        showLine();

        String words3 = " 456 ";
        String str3 = words3.Trim();//將字串前面及後面的"空白"刪掉
        Response.Write(str3);

        showLine();
    }

    public void showLine()
    {
        Response.Write("<hr>");
    }
}