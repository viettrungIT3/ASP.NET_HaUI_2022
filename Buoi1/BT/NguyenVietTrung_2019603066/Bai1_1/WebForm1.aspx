<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Bai1_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bài 1_1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center;">
            <h1 style="color: darkviolet">NHẬP HỒ SƠ CÁN BỘ</h1>
            <p style="margin-bottom: 0;">ĐÀO TẠO, BỒI DƯỠNG CHUYÊN MÔN, NGHIỆP VỤ</p>
            <div>
                <h4 style="background-color: darkviolet; color: white; padding: 6px; margin-top: 0;">THÔNG TIN CÁ NHÂN</h4>
                <table width="100%" align="center">
                    <tr>
                        <td width="35%" align="right">
                            <label><i>*Họ và tên: </i></label>
                        </td>
                        <td width="65%">
                            <asp:TextBox ID="txtName" runat="server" Width="100%"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td width="35%" align="right">
                            <label><i>*Ngày sinh(ngày/tháng/năm): </i></label>
                        </td>
                        <td width="65%" align="left">
                            <asp:TextBox ID="txtDay" runat="server" type="number"></asp:TextBox>
                            /
                            <asp:TextBox ID="txtMounth" runat="server" type="number"></asp:TextBox>
                            /
                            <asp:TextBox ID="txtYear" runat="server" type="number"></asp:TextBox>
                            <label>Giới tính: </label>
                            <asp:RadioButton GroupName="MeasurementSystem" runat="server" Text="Nam" Checked="true" />
                            <asp:RadioButton GroupName="MeasurementSystem" runat="server" Text="Nữ" />
                        </td>
                    </tr>
                    <tr>
                        <td width="35%" align="right">
                            <label><i>*Quê quán: </i></label>
                        </td>
                        <td width="65%">
                            <asp:TextBox ID="txtAddress" runat="server" Width="100%"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
            <div>
                <h4 style="background-color: darkviolet; color: white; padding: 6px; margin-top: 0;">TRÌNH ĐỘ HỌC VẤN</h4>
                <table width="100%" align="center">
                    <tr>
                        <td width="35%" align="right">
                            <label><i>*Trình độ văn hoá: </i></label>
                        </td>
                        <td width="65%" align="left">
                            <asp:TextBox ID="txtCulturalLevel" runat="server"></asp:TextBox>
                            Học vị: <asp:DropDownList ID="listDegree" runat="server"></asp:DropDownList>
                            Học hàm: <asp:DropDownList ID="listAcademicRank" runat="server"></asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td width="35%" align="right">
                            <label><i>Lý luận chính trị: </i></label>
                        </td>
                        <td width="65%" align="left">
                            <asp:DropDownList ID="listLyLuanChinhTri" runat="server"></asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td width="35%" align="right">
                            <label><i>Ngoại ngữ: </i></label>
                        </td>
                        <td width="65%" align="left">
                            <asp:CheckBoxList ID="checkboxLanguage" runat="server" RepeatColumns="3">
                                <asp:ListItem Selected="True">Anh</asp:ListItem>
                                <asp:ListItem>Pháp</asp:ListItem>
                                <asp:ListItem>Nga</asp:ListItem>
                            </asp:CheckBoxList>
                        </td>
                    </tr>
                    <tr>
                        <td width="35%" align="right">
                            <label><i>Ghi rõ tên trường, ngành học, thời gian, loại hình, văn bằng: </i></label>
                        </td>
                        <td width="65%" align="left">
                            <asp:TextBox ID="txtInfoOther" runat="server" TextMode="MultiLine" Rows="4" Width="100%"></asp:TextBox>
                        </td>
                    </tr>
                    <tr><td colspan="2"><span style="color:blue">** Loại hình: Chính quy, tại chức, chuyên tu, bồi dưỡng; Văn bằng: Tiến sĩ, thạc sĩ, cử nhân, kỹ sư.</span></td></tr>
                </table>
            </div>
            <div>
                <h4 style="background-color: darkviolet; color: white; padding: 6px; margin-top: 0;">TÓM TẮT QUẤ TRÌNH CÔNG TÁC</h4>
                <table width="100%" align="center">
                    <tr>
                        <td width="35%" align="right">
                            <label><i>Ghi rõ thời gian bắt đầu và kết thúc; chức danh, chức vụ, đợn vị công tác tương ứng </i></label>
                        </td>
                        <td width="65%" align="left">
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Rows="4" Width="100%"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
            <div style="margin:auto">
                <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật"/>
                <span style="margin:0 4px"></span>
                <asp:Button ID="btnReset" runat="server" Text="Nhập mới"/>
            </div>
        </div>
    </form>
</body>
</html>
