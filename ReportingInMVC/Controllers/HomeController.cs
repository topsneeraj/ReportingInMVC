using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReportingInMVC.EDM;
namespace ReportingInMVC.Controllers
{
    public class HomeController : Controller
    {
        studentdbEntities dc = new studentdbEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewData()
        {
            var p = dc.tblemps.ToList();
            return View(p);
        }
    }
}