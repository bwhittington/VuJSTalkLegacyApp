using LegacyApplication.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LegacyApplication.Web.Controllers
{
    public class ServicesController : Controller
    {
        public ActionResult Index()
        {
            var service = new MockService();
            return View(service.GetAccount());
        }

        public JsonResult GetData()
        {
            var service = new MockService();
            return Json(service.GetAccount(), JsonRequestBehavior.AllowGet);
        }
    }
}