using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTalks.BusinessLayer;
using TechTalks.BusinessLayer.Interface;

namespace TechTalks.Web.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        //public HomeController

        private IBusiness _businessObj = null;

        public HomeController(IBusiness businessObj)
        {
            _businessObj = businessObj;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Post Your query here..";

            if (_businessObj != null)
                _businessObj.AddPost();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
