using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cocTest.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult Introduction()
        {
            

            return View();
        }
        
        public ActionResult HomeworkD1()
        {
            

            return View();
        }
        
        public ActionResult coc()
        {
            return View();
        }
    }
}