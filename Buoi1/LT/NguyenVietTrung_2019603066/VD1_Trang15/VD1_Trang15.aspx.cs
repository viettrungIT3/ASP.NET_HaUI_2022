using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VD1_Trang15
{
    public partial class VD1_Trang15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButTinh_Click(object sender, EventArgs e)
        {
            int so1, so2, tong;
            so1 = int.Parse(txtSoA.Text);
            so2 = int.Parse(txtSoB.Text);
            tong = so1 + so2;
            txtTong.Text = tong.ToString();
        }
    }
}