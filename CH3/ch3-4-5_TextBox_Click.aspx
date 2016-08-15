<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="ch3-4-5_TextBox_Click.aspx.cs" Inherits="ch3_4_5_TextBox_Click" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>按下TextBox，能否觸發Click事件??</strong>
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button_隱藏，Visible=false" Visible="False" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
