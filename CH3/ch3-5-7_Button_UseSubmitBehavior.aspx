<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3-5-7_Button_UseSubmitBehavior.aspx.cs" Inherits="ch3_5_7_Button_UseSubmitBehavior" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            底下的送出按鈕，只能使用一次<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Submit/送出" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
