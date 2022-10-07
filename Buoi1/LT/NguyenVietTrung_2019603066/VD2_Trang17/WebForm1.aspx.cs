using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VD2_Trang17
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                listKhuDL.Items.Add("Vịnh Hạ Long");
                listKhuDL.Items.Add("Phan Thiết - Mũi Né");
                listKhuDL.Items.Add("Nha Trang");
                listKhuDL.Items.Add("Đà Lạt");
            }
        }

        protected void btnChon_Click(object sender, EventArgs e)
        {
            labelDiaDiem.Text = "";
            if(listKhuDL.SelectedItem.Selected)
            {
                labelDiaDiem.Text = "Bạn đã chọn:" + listKhuDL.SelectedValue;
            }
        }
    }
}