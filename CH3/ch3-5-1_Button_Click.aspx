<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3-5-1_Button_Click.aspx.cs" Inherits="ch3_5_1_Button_Click" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            欄位一：<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox><br />
            <br />
            <asp:Button ID="Button1" runat="server" 
                Text="請按我&#010;Submit" 
                OnClick="Button1_Click" /><br />
        </div>
    </form>
</body>
</html>
