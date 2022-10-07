<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="VD2_Trang17.WebForm1" %>

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
                    <td style="width: 40%">
                        <asp:Label ID="Label1" runat="server" Text="Khu du lịch"></asp:Label>
                    </td>
                    <td>
                        <asp:ListBox ID="listKhuDL" SelectionMode="Multiple" Rows="4" runat="server" Width="250"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnChon" runat="server" Text="Chọn địa điểm" OnClick="btnChon_Click"/>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Label ID="labelDiaDiem" runat="server" Text="" ></asp:Label>
                    </td>
                </tr>
            </table>
        </div>

    </form>
</body>
</html>
