<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VD2TinhLuong.aspx.cs" Inherits="BaiTap1.VD2TinhLuong" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table border="1" cellpadding="0" cellspacing="0">
                 <tr>
                     <td>
                         Mã NV:
                     </td>
                     <td>
                         <asp:TextBox ID="txtMaNV" runat="server"></asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         Bậc Lương:
                     </td>
                     <td>
                         <asp:TextBox ID="txtBacLuong" runat="server"></asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         Ngày Công:
                     </td>
                     <td>
                         <asp:TextBox ID="txtNgayCong" runat="server"></asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         Chức Vụ:
                     </td>
                     <td>
                         <asp:DropDownList ID="select" runat="server" AutoPostBack="True" >
                            
                        </asp:DropDownList>
                     </td>
                 </tr>
                 
                 <tr>
                     <td>
                         <asp:Button ID="btnTinh" runat="server" Text="Tính" OnClick="btnTinh_Click" />
                         <asp:Button ID="btnXoa" runat="server" Text="Xóa" />
                     </td>
                 </tr>

             </table>
        </div>
    </form>

</body>
</html>
