<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMemoWrite.aspx.cs" Inherits="DBHandlingWebApp.FrmMemoWrite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>메모입력</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>메모입력</h3>
            이름 : <asp:TextBox ID="TextName" runat="server" /><br />
            이메일 : <asp:TextBox ID="TextEmail" runat="server" /><br />
            메모 : <asp:TextBox ID="TxtTitle" runat="server" /><br />
            <%-- &nbsp는 웹페이지상에서 스페이스를 나타낸다. --%>
            <asp:Button ID="BtnWirte" Text="저장" runat="server" OnClick="BtnWirte_Click" />&nbsp; 
            <asp:Button ID="BtnList" Text="리스트" runat="server" OnClick="BtnList_Click" />
            <hr />
            <asp:Label ID="LblResult" runat="server" />
        </div>
    </form>
</body>
</html>
