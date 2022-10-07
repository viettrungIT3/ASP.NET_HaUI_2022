using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VD6_Trang24
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string sName = txtUserName.Text;
            string sPasss = txtPassword.Text;

            Response.Redirect("WebForm2.aspx?Name=" + sName + "&Pass=" + sPasss);
        }
    }
}