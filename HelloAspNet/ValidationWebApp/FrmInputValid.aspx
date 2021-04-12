<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmInputValid.aspx.cs" Inherits="ValidationWebApp.FrmInputValid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>유효성검사</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TxtAge" runat="server" />
            <asp:RangeValidator ID="ValAge" runat="server" ControlToValidate="TxtAge" ErrorMessage="나이는 1~150사이의 정수입니다." MinimumValue="1" MaximumValue="150" Type="Integer" Display="Dynamic" SetFocusOnError="true" />
            <asp:RangeValidator ID="ValScore" runat="server" ControlToValidate="TxtScore" EroorMessage="학점은 A~F입니다." MinimumValue="A" MaximumValue="F" Type="String" Display="Dynamic" SetFocusOnError="true"/>
            <asp:TextBox ID="TxtUserId" runat="server" />
            <asp:RequiredFieldValidator ID="ValUserId" runat="server" ControlToValidate="TxtUserId"
                ErrorMessage="아이디를 입력하세요" Display="Dynamic" />(필수)<br />
            <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" />
            <asp:RegularExpressionValidator ID="ValPassword" runat="server"
                ControlToValidate="TxtPassword" ErrorMessage="암호를 입력하세여" Display="Dynamic" ForeColor="Red" />(필수)<br />
            <asp:TextBox ID="TxtConfirmPassword" runat="server" TextMode="Password" />
            <asp:RegularExpressionValidator ID="ValConfirmPassword" runat="server"
                ControlToValidate="TxtPassword" ErrorMessage="암호를 입력하세여" Display="Dynamic" ForeColor="Red" />(필수)<br />
            <asp:Button ID="BtnLogin" runat="server" OnClick="BtnLogin_Click" Text="로그인"/>
        </div>
    </form>
</body>
</html>
<%--8장 유효성체크부분 걍따라하면 된다.  --%>