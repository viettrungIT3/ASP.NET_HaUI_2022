using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab06.Models;

namespace Lab06.Controllers
{
    public class NhapDiemController : Controller
    {
        // GET: NhapDiem
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save(SinhVien sv)
        {
            // Đường dẫn lưu file
            string path = Server.MapPath("~/StudentInfo.txt");

            // Khai báo mảng xâu ký tự để lưu dữ liệu
            string[] lines = { sv.Id, sv.Name, sv.Mark.ToString() };

            // Ghi thông tin vào file
            System.IO.File.WriteAllLines(path, lines);

            ViewBag.HanhDong = "Đã lưu vào file";
            return View("Index");
        }

        public ActionResult Open(SinhVien sv)
        {
            // Đường dẫn file
            string path = Server.MapPath("~/StudentInfo.txt");

            // Đọc file từ file
            string[] lines = System.IO.File.ReadAllLines(path);

            // Gán lại giá trị
            sv.Id = lines[0];
            sv.Name = lines[1];
            sv.Mark = Convert.ToDouble(lines[2]);

            // Hiển thị
            ViewBag.ThongTin = "Mã SV: " + sv.Id +
                                " - Họ tên: " + sv.Name +
                                " - Điểm: " + sv.Mark;
            ViewBag.HanhDong = "Đọc thông tin từ file";
            
            return View("Index", sv);
        }


    }
}