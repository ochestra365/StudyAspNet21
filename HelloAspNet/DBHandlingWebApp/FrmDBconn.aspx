﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmDBconn.aspx.cs" Inherits="DBHandlingWebApp.FrmDBconn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>DB연결저장</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnConn" runat="server" Text="데이터입력" onClick="BtnConn_Click"/>
            <br />
            <asp:Label ID="LblResult" runat="server" />
        </div>
    </form>
</body>
</html>
