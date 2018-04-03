using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ch06_Controller.Controllers
{
    public class CtoVController : Controller
    {
        // GET: CtoV
        public ActionResult DemoViewData()
        {
            ViewData["Name"] = "这是ViewData";
            return View();
        }

        public ActionResult DemoViewBag()
        {
            ViewBag.h = "DemoViewBag";
            ViewBag.Name = "boy";
            return View();
        }
    }
}