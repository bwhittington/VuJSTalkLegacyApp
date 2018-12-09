using LegacyApplication.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LegacyApplication.Web.Controllers
{
    public class ComponentController : Controller
    {
        public ActionResult Index()
        {
            var service = new MockService();
            return View(service.GetAccount());
        }
    }
}