<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TienDien.aspx.cs" Inherits="VD5_Trang23.TienDien" %>

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
                    <td><label>Vào chỉ số điện cũ: </label></td>
                    <td><asp:TextBox ID="txtNumberOld" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><label>Vào chỉ số điện mới: </label></td>
                    <td><asp:TextBox ID="txtNumberNew" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" align="center"><asp:Button ID="btnSearch" runat="server" Text="Tìm kiếm" PostBackUrl="~/XL_TienDien.aspx"/></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
