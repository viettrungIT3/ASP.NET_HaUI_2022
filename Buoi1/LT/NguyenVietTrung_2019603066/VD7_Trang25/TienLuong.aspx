<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TienLuong.aspx.cs" Inherits="VD7_Trang25.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <label>Mã NV:</label></td>
                    <td>
                        <asp:TextBox ID="txtMaNV" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Bậc Lương:</td>
                    <td>
                        <asp:TextBox ID="txtLuong" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Ngày công:</td>
                    <td>
                        <asp:TextBox ID="txtNgayCong" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <label>Chức vụ:</label></td>
                    <td>
                        <asp:DropDownList ID="listChucVu" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnTinh" style="margin-right:5px;" runat="server" Text="Tính" PostBackUrl="~/XL_TienLuong.aspx" OnClick="btnTinh_Click"/>
                        <asp:Button ID="btnXoa" style="margin-left:5px;" runat="server" Text="Xoá" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
