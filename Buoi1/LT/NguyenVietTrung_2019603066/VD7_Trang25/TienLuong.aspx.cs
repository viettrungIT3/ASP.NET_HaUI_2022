using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VD7_Trang25
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            listChucVu.Items.Add("Trưởng phòng");
            listChucVu.Items.Add("Phó phòng");
            listChucVu.Items.Add("Nhân viên");
        }

        protected void btnTinh_Click(object sender, EventArgs e)
        {
            string sMaNV = txtMaNV.Text;
            string sBacLuong = txtLuong.Text;
            string sNgayCong= txtNgayCong.Text;
            string sChucVu = listChucVu.SelectedItem.Text;

            //Response.Redirect("XL_TienLuong.aspx?MaNV=" + sMaNV +
            //    "&BacLuong=" + sBacLuong + "&NgayCong=" + sNgayCong +
            //    "&ChucVu=" + sChucVu);

            Response.Redirect("XL_TienLuong.aspx?Name=" + sMaNV);
        }
    }
}