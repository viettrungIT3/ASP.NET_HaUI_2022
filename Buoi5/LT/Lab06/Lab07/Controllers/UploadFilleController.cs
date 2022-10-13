using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Lab07.Controllers
{
    public class UploadFilleController : Controller
    {
        // GET: UploadFille
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UploadFile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile( HttpPostedFileBase file)
        {
            try
            {
                if(file.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
                    file.SaveAs(_path);
                }
                ViewBag.Message = "Uploade file successfully!";
                return View();
            }
            catch
            {
                ViewBag.Message = "Uploade file failsed!";
                return View();
            }
        }


    }
}