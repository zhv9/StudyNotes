using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ch06_Controller.Controllers
{
    public class TempDataController : Controller
    {
        // GET: TempData
        public ActionResult DemoInput()
        {
            return View();
        }

        public ActionResult CheckInput(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                TempData["Error"] = "不能空白";
                return RedirectToAction("DemoInput");
            }
            ViewBag.Name = name;
            return View();
        }
    }
}