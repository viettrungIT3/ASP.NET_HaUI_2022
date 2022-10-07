using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai4_4.Controllers
{
    public class TienLinhController : Controller
    {
        // GET: TienLinh
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tinh(FormCollection data)
        {
            ViewBag.maNV = data["maNV"];
            double bacLuong= Convert.ToDouble( data["bacLuong"]);
            int ngayCong= Convert.ToInt32( data["ngayCong"]);
            string chucVu = data["chucVu"];

            ViewBag.ngayCong = ngayCong;

            int nctl = (ngayCong < 25) ? ngayCong : (ngayCong - 25) * 2 + 25;
            int phuCap = 0;
            if (chucVu == "Trưởng phòng")
                phuCap = 500000;
            else if (chucVu == "Phó phòng")
                phuCap = 300000;

            double tongTien = bacLuong * 650000 * nctl + phuCap;

            ViewBag.tongTien = tongTien.ToString();

            return View();
        }

    }
}