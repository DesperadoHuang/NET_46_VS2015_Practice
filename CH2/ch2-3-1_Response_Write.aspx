<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch2-3-1_Response_Write.aspx.cs" Inherits="ch2_3_1_Response_Write" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%Response.Write("<hr>InLine Code<hr>"); %>
            <%=("用=號來取代Response.Write()") %>
        </div>
    </form>
</body>
</html>
