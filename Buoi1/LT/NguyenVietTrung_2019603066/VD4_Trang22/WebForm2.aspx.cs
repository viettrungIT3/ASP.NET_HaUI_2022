using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VD4_Trang22
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblKetQua.Text = "User name: " + Request.Form.Get("txtUserName") +
                            " <br>Password: " + Request.Form.Get("txtPassword");
        }
    }
}