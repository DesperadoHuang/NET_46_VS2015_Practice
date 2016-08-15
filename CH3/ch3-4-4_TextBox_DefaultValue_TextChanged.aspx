<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3-4-4_TextBox_DefaultValue_TextChanged.aspx.cs" Inherits="ch3_4_4_TextBox_DefaultValue_TextChanged" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            輸入一個TextBox的預設值，是否觸發TextBoxChanged事件?<br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button_輸入一個TextBox的預設值" OnClick="Button1_Click" /><br />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            ( AutoPostBack = true )<br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
