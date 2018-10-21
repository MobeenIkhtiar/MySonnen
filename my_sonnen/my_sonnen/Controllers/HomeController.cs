using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using my_sonnen.Models;
using my_sonnen.BL;
using System.Web.Mvc;

namespace my_sonnen.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            ViewBag.Installer = new AdminBL().getAllInstallersList().ToList();
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //Ajax Call
        public JsonResult getlevel(int Id)
        {
            Installer ins = new AdminBL().getAllInstallersList().Where(x => x.Id == Id).FirstOrDefault();
            if (ins!=null && ins.FreeWarranty!=1)
             return Json(new { obj = ins.Level }, JsonRequestBehavior.AllowGet);
            else
              return Json(new { obj = "Free" }, JsonRequestBehavior.AllowGet);
        }
    }
}