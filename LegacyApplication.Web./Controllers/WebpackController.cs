using LegacyApplication.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LegacyApplication.Web.Controllers
{
    public class WebpackController : Controller
    {
        public WebpackController()
        {
            var mockService = new MockService();
        }

        public ActionResult Index()
        {
            var service = new MockService();
            return View(service.GetAccount());
        }
    }
}