<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3-2-1_TextBox_TextMode.aspx.cs" Inherits="ch3_3_1_TextBox_TextMode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            簡單的練習<br />
            每一個在畫面上設定的屬性，都可以在後製程式碼中動態地更變它的值。<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
