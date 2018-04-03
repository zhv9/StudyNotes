using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Ch06_Controller.Models;

namespace Ch06_Controller.Controllers
{
    public class CtoVModelController : Controller
    {
        private Northwind db = new Northwind();

        // GET: CtoVModel
        public ActionResult CtoVModel()
        {
            ViewData["products"] = db.Products.ToList();
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
