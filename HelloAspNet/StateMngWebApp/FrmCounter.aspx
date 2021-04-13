<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCounter.aspx.cs" Inherits="StateMngWebApp.FrmCounter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>카운터</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            현재접속자 : <asp:Label ID="LblVisit" runat="server" />
        </div>
    </form>
</body>
</html>
