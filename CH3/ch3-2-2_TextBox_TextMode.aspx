<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3-2-2_TextBox_TextMode.aspx.cs" Inherits="ch3_2_2_TextBox_TextMode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ASP.NET 4.5 for HTML5<br /><br />
            Color--<asp:TextBox ID="textBox_Color" runat="server"></asp:TextBox><br />
            Email--<asp:TextBox ID="textBox_Email" runat="server"></asp:TextBox><br />
            URL--<asp:TextBox ID="textBox_URL" runat="server"></asp:TextBox><br />
            DateTime--<asp:TextBox ID="textBox_DateTime" runat="server"></asp:TextBox><br />
            Range--<asp:TextBox ID="textBox_Range" runat="server"></asp:TextBox><br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="動態更動TextBox_TextMode屬性" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
