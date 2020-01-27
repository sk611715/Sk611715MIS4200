using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sk611715MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Stephanie Kasunick";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Stephanie Kasunick";

            return View();
        }
    }
}