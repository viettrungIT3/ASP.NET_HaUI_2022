using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai5_1.Models;
using System.IO;

namespace Bai5_1.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(FormCollection data)
        {
            // Lấy thông tin từ input type = file
            var fImage = Request.Files["myFileImage"];

            // Save hình về server
            var pathImage = Server.MapPath("~/Images/" + fImage.FileName);
            fImage.SaveAs(pathImage);
            string path = Server.MapPath("~/StaffInfo.txt");
            string[] info = { data["txtID"], data["txtName"], data["txtDate"], data["txtSalary"], fImage.FileName };

            // Ghi file vào StaffInfo.txt
            System.IO.File.WriteAllLines(path, info);
            ViewBag.msg = path;
            return View("Index");
        }

        public ActionResult Open()
        {
            // Đọc lại file từ server
            string path = Server.MapPath("~/StaffInfo.txt");
            string[] info = System.IO.File.ReadAllLines(path);

            Staff s = new Staff();
            s.StraffId = int.Parse(info[0]);
            s.StaffName = info[1];
            s.BirthOfDate = DateTime.Parse(info[2]);
            s.Salary = decimal.Parse(info[3]);
            s.StaffImage = info[4];

            // Chuyển các thông tin từ Controler sang view 
            ViewBag.Id = s.StraffId;
            ViewBag.Name = s.StaffName;
            ViewBag.Birthday = s.BirthOfDate.ToString("yyyy-MM-dd");
            ViewBag.Salary = s.Salary;
            ViewBag.Image = "../../images/" + s.StaffImage; 

            return View("Index");
        }
    }
}