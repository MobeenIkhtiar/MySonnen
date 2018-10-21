using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using my_sonnen.Models;
using my_sonnen.BL;
using System.Web.Mvc;

namespace my_sonnen.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult registeredusers()
        {
            List<ExtendedWarranty> list = new AdminBL().getExtendedWarrantysList().ToList();
            return View(list);
        }
        public ActionResult AddInstaller(string err,string msg)
        {
            return View();
        }
        [HttpPost]
        public ActionResult PostAddInstaller(Installer obj)
        {
            bool temp=new AdminBL().AddInstallers(obj);
            if (temp)
            return RedirectToAction("AddInstaller",new { msg="You have successfully added installer."});
            return RedirectToAction("AddInstaller",new { err="Please fill all fields carefully!"});
        }
        public ActionResult installers()
        {
            List<Installer> list = new AdminBL().getAllInstallersList().ToList();
            return View(list);
        }
    }
}