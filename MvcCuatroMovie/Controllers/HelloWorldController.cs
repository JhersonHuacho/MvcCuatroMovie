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
        public string Index()
        {
            return "This is my <b>default<b/> action...";
        }

        // GET: /HelloWorld/Welcome/
        // http://localhost:xxxx/HelloWorld/Welcome?name=Scott&numtimes=4
        public string Welcome(string name, int numTimes = 1)
        {
            //return "This is the welcome action method...";
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        }
    }
}