<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3-5-5_Buttons.aspx.cs" Inherits="ch3_5_5_Buttons" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Button (包含了--Button、LinkButton、ImageButton)的PostBackUrl屬性<br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" PostBackUrl="https://www.youtube.com" /><br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="http://www.ambassador.com.tw/">LinkButton</asp:LinkButton><br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/MDK10small.jpg" PostBackUrl="https://tw.mall.yahoo.com/" />
        </div>
    </form>
</body>
</html>
