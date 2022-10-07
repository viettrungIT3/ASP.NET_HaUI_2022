<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VD1_Trang15.aspx.cs" Inherits="VD1_Trang15.VD1_Trang15" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <title></title>
    </head>

    <body>
        <form id="form1" runat="server">
            <div>
                <table border="1" cellpadding="0" cellspacing="0" <tr>
                    <td style="width:40%">
                        <asp:Label ID="Label1" runat="server" Text="Nhập số A:" Width="100px"></asp:Label>
                    </td>
                    <td>
                        <%--<asp:TextBox ID="txtSoA" runat="server" Width="100px"></asp:TextBox>--%>
                        <asp:TextBox ID="txtSoA" runat="server" Width="100px"></asp:TextBox>

                    </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Nhập số B:" Width="100px"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtSoB" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Tổng:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtTong" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="center">
                            <asp:Button ID="ButTinh" runat="server" Text="Tính tổng" OnClick="ButTinh_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </form>
    </body>

    </html>