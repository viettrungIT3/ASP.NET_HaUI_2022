﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VD6_Trang24
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblKetQua.Text = "Username: " + Request.QueryString["Name"].ToString() +
                            "<br>Password: " + Request.QueryString["Pass"].ToString();
        }
    }
}