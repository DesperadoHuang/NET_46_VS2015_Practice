<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3-2-4_TextBox_AutoPostBack_EnableViewStat.aspx.cs" Inherits="ch3_2_4_TextBox_AutoPostBack_EnableViewStat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            欄位一：<asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="textBox1OnTextChanged"></asp:TextBox>AutoPostBack=true<br />
            ===========================================================<br />
            欄位二：<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2OnTextChanged"></asp:TextBox>AutoPostBack=false<br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
