using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai1_22
{
    public partial class XL_TienLuong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Redirect("XL_TienLuong.aspx?MaNV=" + maNV + "&BacLuong=" + bacLuong +
            //    "&NgayCong=" + ngayCong + "&ChucVu=" + chucVu);
            TienLinh.Text = "";
            string maSV = Request.QueryString["MaNV"].ToString();
            float bacLuong = float.Parse(Request.QueryString["BacLuong"].ToString());
            int ngayCong = int.Parse(Request.QueryString["NgayCong"].ToString());
            string chucVu = Request.QueryString["ChucVu"].ToString();

            txtMaNV.Text = maSV;
            txtNgayCong.Text = ngayCong.ToString();

            int nctl;
            if (ngayCong < 25)
                nctl = ngayCong;
            else
                nctl = (ngayCong - 25) * 2 + 25;

            int phuCap;
            if (chucVu == "Trưởng phòng")
                phuCap = 500000;
            else if (chucVu == "Phó phòng")
                phuCap = 300000;
            else phuCap = 100000;

            double tienLinh = bacLuong * 650000 * nctl + phuCap;

            TienLinh.Text = tienLinh.ToString();
        }
    }
}