using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VD3_Trang20
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void rblThu_Nhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelThu_Nhap.Text = "Bạn đã chọn: " + rblThu_Nhap.SelectedItem.Text;
        }
    }
}