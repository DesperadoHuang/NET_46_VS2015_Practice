<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3-6-1_Button_CommandName.aspx.cs" Inherits="ch3_6_1_Button_" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title></head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server"
                CommandArgument="CommandArgument測試"
                Text="Button/測試(test)" 
                OnClick="Button1_Click" OnCommand="Button1_Command" />
        </div>
    </form>
</body>
</html>
