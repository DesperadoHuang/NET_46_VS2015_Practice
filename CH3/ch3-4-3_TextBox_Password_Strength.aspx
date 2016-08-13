<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3-4-3_TextBox_Password_Strength.aspx.cs" Inherits="ch3_4_3_TextBox_Password_Strength" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    密碼強度範例<br />
        請輸入文字、數字、符號<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        (AutoPostBack=true)<br />
        <br /><br />
        請輸入姓名：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <br />
        <asp:Image ID="Image1" runat="server" />
    </div>
    </form>
</body>
</html>
