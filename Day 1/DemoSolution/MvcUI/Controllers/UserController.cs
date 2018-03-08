using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LogicS;

namespace MvcUI.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(string userName)
        {
            ViewBag.Message = GreetingClass.GreetingMethod(userName);
            return View("About");
        }
    }
}