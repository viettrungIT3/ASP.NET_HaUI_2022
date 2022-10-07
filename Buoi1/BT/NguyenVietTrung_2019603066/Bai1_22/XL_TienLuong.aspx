<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XL_TienLuong.aspx.cs" Inherits="Bai1_22.XL_TienLuong" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" cellspacing="0" style="width: 500px">
                <tr>
                    <td style="width: 30%">Mã NV:</td>
                    <td style="width: 70%">
                        <asp:TextBox ID="txtMaNV" runat="server" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 30%">Ngày công:</td>
                    <td style="width: 70%">
                        <asp:TextBox ID="txtNgayCong" runat="server" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td style="width: 30%">Tiền được lĩnh:</td>
                    <td style="width: 70%">
                        <asp:Label ID="TienLinh" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
