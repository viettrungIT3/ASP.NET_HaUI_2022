using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai4_1.Models;

namespace Bai4_1.Controllers
{
    public class CalculateController : Controller
    {
        // GET: Calculate
        public ActionResult Index(Calculate c)
        {
            ViewBag.KetQua = c.Tinh();
            return View();
        }
    }
}