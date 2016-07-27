<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch2-3-3_Response_Redirect.aspx.cs" Inherits="ch2_3_3_Response_Redirect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <%Response.Redirect("http://www.asp.net/"); %>
        </div>
    </form>
</body>
</html>
