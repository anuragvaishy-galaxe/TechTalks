using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechTalks.Web.Controllers
{
    public class ThreadController : Controller
    {
        //
        // GET: /Thread/

        public ActionResult CreateThread()
        {
            return View();
        }

    }
}
