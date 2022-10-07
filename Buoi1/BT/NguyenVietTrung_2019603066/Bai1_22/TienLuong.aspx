<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TienLuong.aspx.cs" Inherits="Bai1_22.TienLuong" %>

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
                        <asp:TextBox ID="txtMaNV" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 30%">Bậc lương:</td>
                    <td style="width: 70%">
                        <asp:TextBox ID="txtBacLuong" runat="server" TextMode="Number" min="0" step="0.1"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 30%">Ngày công:</td>
                    <td style="width: 70%">
                        <asp:TextBox ID="txtNgayCong" TextMode="Number" min="0" max="30" runat="server"></asp:TextBox>
                        <%--<asp:TextBox ID="" Text="8" Width="50px" max="10" min="1"></asp:TextBox>--%>
                    </td>
                </tr>
                <tr>
                    <td style="width: 30%">Chức vụ:</td>
                    <td style="width: 70%">
                        <asp:DropDownList ID="listChucVu" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="width: 30%">Giới tính:</td>
                    <td style="width: 70%">
                        <asp:RadioButtonList runat="server" AutoPostBack="true" RepeatColumns="2">
                            <asp:ListItem Selected="True">Nam</asp:ListItem>
                            <asp:ListItem>Nữ</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td style="width: 30%">Ngoại ngữ:</td>
                    <td style="width: 70%">
                        <asp:CheckBoxList runat="server" RepeatColumns="3">
                            <asp:ListItem Selected="True">Anh</asp:ListItem>
                            <asp:ListItem>Pháp</asp:ListItem>
                            <asp:ListItem>Nga</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td style="width: 30%">Tiền lĩnh:</td>
                    <td style="width: 70%">
                        <asp:Label ID="TienLinh" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <div style="margin: auto">
                            <asp:Button ID="btnTinh" runat="server" Text="TÍNH" OnClick="btnTinh_Click" />
                            <span style="margin: 0 8px"></span>
                            <asp:Button ID="btnReset" runat="server" Text="XOÁ" />
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
