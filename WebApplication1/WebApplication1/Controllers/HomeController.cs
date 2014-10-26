using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.UI;
using DevTrends.MvcDonutCaching;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [DonutOutputCache(Duration = 180, Location = OutputCacheLocation.Server)]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public PartialViewResult Information()
        {
            return PartialView();
        }


        [DonutOutputCache(Duration = 60)]
        public PartialViewResult Information2()
        {
            return PartialView();
        }

        [DonutOutputCache(Duration = 15, Location = OutputCacheLocation.Server)]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}