<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmStandardControl.aspx.cs" Inherits="FirstWebApp.FrmStandardControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>표준컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>표준컨트롤</h1>

            <asp:TextBox ID="TxtUserID" runat="server" TextMode="SingleLine"/><br />
            <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"/><br />
            <asp:TextBox ID="TxtDesc" runat="server" TextMode="MultiLine"/><br />

            <asp:Label ID="LblDateTime" runat="server" Text="sample"/><br />
            <input type="button" value="버튼1" id="BtnInput" runat="server" onclick=""/><br />
            <input type="button" value="버튼2" id="BtnHtml" runat="server" onclick="" /><br />
            <asp:Button Text="버튼3" runat="server" ID="BtnServer" Onclick="BtnServer_Click"/>
        </div>
    </form>
</body>
</html>
