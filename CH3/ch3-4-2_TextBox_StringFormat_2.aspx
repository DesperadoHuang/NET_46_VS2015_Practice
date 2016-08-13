<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3-4-2_TextBox_StringFormat_2.aspx.cs" Inherits="ch3_4_2_TextBox_StringFormat_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    輸入數字，進行計算。結果須以「貨幣」格式出現。<br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"></asp:TextBox>
        +
        <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True"></asp:TextBox>
        +
        <asp:TextBox ID="TextBox3" runat="server" AutoPostBack="True" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        =
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
        <br />
         計算時不需按扭送出(Submit)<br />
        先把TextBox的「AutoPostBack 」屬性開啟
    </div>
    </form>
</body>
</html>
