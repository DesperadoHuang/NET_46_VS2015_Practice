<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3-1-4_PageLoad_IsPostBack.aspx.cs" Inherits="ch3_1_4_PageLoad_IsPostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            不管在畫面(Page)上，按下任何按鈕或是店選控制項<br />
            重新載入頁面時，都會在一次觸發Page_Load 事件<br />
            <br />
            點擊次數：<asp:Label ID="Label1" runat="server" Text="0"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="增加點擊次數" />
        </div>
        </div>
    </form>
</body>
</html>
