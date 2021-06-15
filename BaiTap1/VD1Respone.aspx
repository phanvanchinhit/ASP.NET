<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VD1Respone.aspx.cs" Inherits="BaiTap1.VD1Respone" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang gửi</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username:
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br />
            Password:
            <asp:TextBox ID="txtPass" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
        </div>
    </form>
</body>
</html>
