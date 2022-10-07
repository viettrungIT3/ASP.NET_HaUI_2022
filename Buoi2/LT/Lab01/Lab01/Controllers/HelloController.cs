using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        //public String Index()
        //{
        //    return "Đây là phương thức Index, phương thức mặc định của Controller Hello";
        //}

        ////public String ChaoMung()
        ////{
        ////    return "Đây là phương thức ChaoMung nam trong Controller Hello";
        ////}

        //public string ChaoMung(string ten, int id = 1)
        //{
        //    return ("Xin chao " + ten + ". ID = " + id);
        //}
    }
}