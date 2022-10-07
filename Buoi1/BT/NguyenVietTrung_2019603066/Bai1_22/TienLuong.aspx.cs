using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai1_22
{
    public partial class TienLuong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            listChucVu.Items.Add("Trưởng phòng");
            listChucVu.Items.Add("Phó phòng");
            listChucVu.Items.Add("Nhân viên");
        }

        protected void btnTinh_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string bacLuong = txtBacLuong.Text;
            string ngayCong = txtNgayCong.Text;
            String chucVu = listChucVu.SelectedValue;
            Response.Redirect("XL_TienLuong.aspx?MaNV=" + maNV + "&BacLuong=" + bacLuong +
                "&NgayCong=" + ngayCong + "&ChucVu="  + chucVu);
        }
    }
}