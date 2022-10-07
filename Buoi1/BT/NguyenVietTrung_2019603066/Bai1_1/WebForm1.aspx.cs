using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai1_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // List Degree
            listDegree.Items.Add("Chưa có");
            listDegree.Items.Add("Tú tài");
            listDegree.Items.Add("Cử nhân");
            listDegree.Items.Add("Thạc sỹ");
            listDegree.Items.Add("Tiến sỹ");
            listDegree.Items.Add("Tiến sỹ khoa học");

            // List 
            listAcademicRank.Items.Add("Chưa có");
            listAcademicRank.Items.Add("Phó giáo sư");
            listAcademicRank.Items.Add("Giáo sư");

            // List
            listLyLuanChinhTri.Items.Add("Lý luận chính trị 1");
            listLyLuanChinhTri.Items.Add("Lý luận chính trị 2");
            listLyLuanChinhTri.Items.Add("Lý luận chính trị 3");
            listLyLuanChinhTri.Items.Add("Lý luận chính trị 4");
            listLyLuanChinhTri.Items.Add("Lý luận chính trị 5");
        }
    }
}