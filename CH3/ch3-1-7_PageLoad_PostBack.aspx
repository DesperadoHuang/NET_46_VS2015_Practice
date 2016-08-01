<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3-1-7_PageLoad_PostBack.aspx.cs" Inherits="ch3_1_7_PageLoad_PostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            點擊次數：<asp:Label ID="Label1" runat="server" Text="0"></asp:Label><br />
            <br />
            <input id="Submit1" type="submit" value="HTML_submit，會觸發PostBack" /><br />
            <br />
            <input id="button1" type="button" value="HTML_button，「不會」觸發PostBack" /><br />
        </div>
    </form>
</body>
</html>
