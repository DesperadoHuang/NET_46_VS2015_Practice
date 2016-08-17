<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3-5-6_Button_JavaScript_Alert.aspx.cs" Inherits="image_ch3_5_6_Button_JavaScript_Alert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="window.alert(&quot;警告視窗！&quot;);" /><br />
            <br />
            按下按鈕，就會出現一個JavaScrip寫的提醒視窗<br />

        </div>
    </form>
</body>
</html>
