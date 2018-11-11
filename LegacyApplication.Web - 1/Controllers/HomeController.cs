using LegacyApplication.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LegacyApplication.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            var mockService = new MockService();
        }

        public ActionResult Index()
        {
            var service = new MockService();
            return View(service.GetAccount());
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