using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VD5_Trang23
{
    public partial class XL_TienDien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int num = int.Parse(Request.Form.Get("txtNumberNew")) - int.Parse(Request.Form.Get("txtNumberOld"));
            int val = 0;
            if (num >= 0 && num <= 100)
            {
                val = num * 2000;
            }
            else if (num <= 150)
            {
                val = 100 * 2000 + (num - 100) * 2500;
            }
            else if (num <= 200)
            {
                val = 100 * 2000 + 50 * 2500 + (num - 150) * 2800;
            }
            else if (num > 200)
            {
                val = 100 * 2000 + 50 * 2500 + 50 * 2800 + (num - 100) * 2500;
            }

            lblTienDien.Text = val.ToString();
        }
    }
}