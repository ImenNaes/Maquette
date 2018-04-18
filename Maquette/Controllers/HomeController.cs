using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Maquette.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Music()
        {
            return View();
        }

        public ActionResult Location()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Message()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Galleries()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Settings()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }









    }
}