using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai4_3.Models;

namespace Bai4_3.Controllers
{
    public class DiemThiController : Controller
    {
        // GET: DiemThi
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tinh(SinhVien sv)
        {
            int diemKV = 0, diemUT = 0;
            if (sv.khuVuc == "Khu vực A")
                diemKV = 1;
            else if (sv.khuVuc == "Khu vực B")
                diemKV = 2;
            else
                diemKV = 3;

            if (sv.check1 == "on")
                diemUT = 1;

            double tongDiem = sv.diemToan + sv.diemLy + sv.diemHoa + diemUT;

            string ketQua = "";
            if (tongDiem >= 20)
                ketQua = "Đỗ đại học";
            else if (tongDiem >= 15)
                ketQua = "Đỗ cao đẳng";
            else if (tongDiem >= 10)
                ketQua = "Đỗ trung cấp";
            else 
                ketQua = "Thi trượt";

            ViewBag.ten = sv.tenSV;
            ViewBag.tongDiem = tongDiem;
            ViewBag.kq = ketQua;

            return View();
        }
    }
}