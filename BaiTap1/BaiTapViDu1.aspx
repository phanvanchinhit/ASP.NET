<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BaiTapViDu1.aspx.cs" Inherits="BaiTap1.BaiTapViDu1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang gửi</title>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div>
            Username:
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br />
            Password:
            <asp:TextBox ID="txtPass" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" PostBackUrl="~/VD1WebForm2.aspx"/>
        </div>
    </form>
</body>
</html>
