<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3-4-1_TextBox_StringFormat.aspx.cs" Inherits="ch3_4_1_TextBox_StringFormat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    輸入數字，進行計算。結果必須以「貨幣」格式出現<br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>+<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>+<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>=<asp:Label ID="Label1" runat="server" Text=" 計算結果"></asp:Label><br />
        <br />
        <asp:Button ID="btSubmit" runat="server" Text="開始計算" OnClick="btSubmit_Click" />
    </div>
    </form>
</body>
</html>
