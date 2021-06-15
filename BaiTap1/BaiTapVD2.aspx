<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BaiTapVD2.aspx.cs" Inherits="BaiTap1.BaiTapVD2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div>
            Số điện cũ:
            <asp:TextBox ID="txtSoCu" runat="server"></asp:TextBox><br />
            Số điện mới:
            <asp:TextBox ID="txtSoMoi" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Tính tiền" PostBackUrl="~/VD2WebForm2.aspx"/>
        </div>
    </form>
</body>
</html>
