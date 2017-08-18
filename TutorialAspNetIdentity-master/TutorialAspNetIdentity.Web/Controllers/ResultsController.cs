using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorialAspNetIdentity.Web.Controllers
{
    public class ResultsController : Controller
    {
        // GET: Result
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
        public ActionResult Deleted()
        {
            return View();
        }

    }
}