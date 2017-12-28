using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CH.HelloWorld.Web.Controllers
{
    public class HomeController : Controller
    {
        private const string HELLO_WORLD = "Hello World";
        public string Index()
        {
            return HELLO_WORLD;
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
    }
}