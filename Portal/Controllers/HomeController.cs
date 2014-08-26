using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal.Controllers
{

    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
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

        public ActionResult AdminHome()
        {
            //return RedirectToAction("Index", "Home", new { area = "FrontEnd" });

            ViewBag.Message = "Your Admin Home page.";

            return View();
        }

        public ActionResult Website()
        {
            return RedirectToAction("Index", "Home", new { area = "FrontEnd" });

            //ViewBag.Message = "Your Admin Home page.";

            //return View();
        }


    }
}