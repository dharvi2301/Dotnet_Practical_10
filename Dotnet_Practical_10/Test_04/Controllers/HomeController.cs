using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_04.Filters;

namespace Test_04.Controllers
{
    public class HomeController : Controller
    {
        [CustomExceptionFilter]
        public ActionResult Index()
        {
            // This will throw a DivideByZeroException
            int x = 10;
            int y = 0;
            int result = x / y;

            return Content("Result: " + result);
        }
    }
}