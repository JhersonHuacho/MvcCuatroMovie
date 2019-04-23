using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCuatroMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        // http://localhost:xxxx/HelloWorld/Welcome?name=Scott&numtimes=4
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            //return "This is the welcome action method...";
            //return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
    }
}