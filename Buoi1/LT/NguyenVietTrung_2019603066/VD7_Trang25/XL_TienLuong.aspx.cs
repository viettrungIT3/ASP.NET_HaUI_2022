using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VD7_Trang25
{
    public partial class XL_TienLuong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = Request.QueryString[""].ToString();
            //txtNgayCong.Text = Request.QueryString["NgayCong"].ToString();
            //int phuCap;
            //string sChucVu = Request.QueryString["ChucVu"].ToString(); ;
            //if (String.Compare(sChucVu, "Trưởng phòng") == 0)
            //{
            //    phuCap = 500000;
            //} else if (String.Compare(Request.QueryString["ChucVu"].ToString(), "Phó phòng", true) == 0)
            //{
            //    phuCap = 500000;
            //} else if (String.Compare(Request.QueryString["ChucVu"].ToString(), "Nhân viên", true) == 0)
            //{
            //    phuCap = 500000;
            //} else
            //{
            //    return;
            //}
        }
    }
}