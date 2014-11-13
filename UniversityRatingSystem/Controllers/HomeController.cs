using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityRatingSystem.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(HomeController));

        public ActionResult Index()
        {
            logger.Info("Index accessed");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            logger.Info("About page accessed");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            logger.Info("Contact page accessed");
            return View();
        }
    }
}