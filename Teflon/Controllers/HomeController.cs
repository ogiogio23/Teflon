using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teflon.Models;

namespace Teflon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.TheMessage = "Having Trouble, send us a message.";

            return View();
        }

        [HttpPost]
        public ActionResult About(Student student)
        {

            return View(student);
        }

        /*[HttpPost]
        public ActionResult About(string message)
        {
            ViewBag.TheMessage = "Thanks, we got your message.";

            return View();
        }*/

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}