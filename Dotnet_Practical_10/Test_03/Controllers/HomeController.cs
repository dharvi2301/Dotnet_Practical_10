using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_03.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration = 300, VaryByParam = "none")]
        public ActionResult Now()
        {
            string currentTime = DateTime.Now.ToString("F"); // Full date/time pattern
            return Content("Current Time: " + currentTime);
        }
    }
}