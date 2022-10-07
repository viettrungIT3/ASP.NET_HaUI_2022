<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XL_TienLuong.aspx.cs" Inherits="VD7_Trang25.XL_TienLuong" %>

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
                        <label>Mã NV: </label></td>
                    <td>
                        <asp:TextBox ID="txtMaNV" runat="server" Enabled="false"></asp:TextBox></td>
                </tr>
                <tr>
                    <td> Có ngày công: </td>
                    <td>
                        <asp:TextBox ID="txtNgayCong" runat="server" Enabled="False"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Tiền được lĩnh: </td>
                    <td>
                        <asp:TextBox ID="txtTienLinh" runat="server" Enabled="False"></asp:TextBox></td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
