using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Test_02.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ContentResult ShowContent()
        {
            return Content("This is a ContentResult response.", "text/plain", Encoding.UTF8);
        }

        public FileContentResult ShowFile()
        {
            byte[] fileBytes = Encoding.UTF8.GetBytes("This is a text file content.");
            return File(fileBytes, "text/plain", "demo.txt");
        }

        public EmptyResult ShowEmpty()
        {
            return new EmptyResult();
        }
        public JavaScriptResult ShowJavaScript()
        {
            string script = "alert('This is a JavaScriptResult!');";
            return JavaScript(script);
        }

        public JsonResult ShowJson()
        {
            var data = new { Name = "John Doe", Age = 30, Country = "USA" };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public RedirectResult ShowRedirect()
        {
            return Redirect("https://www.example.com");
        }
        public RedirectToRouteResult ShowRedirectToRoute()
        {
            return RedirectToAction("Index");
        }

        public HttpStatusCodeResult ShowHttpStatus()
        {
            return new HttpStatusCodeResult(403, "Forbidden Access");
        }
        public ViewResult ShowView()
        {
            ViewBag.Message = "This is the default view loaded by ShowView action!";
            return View(); // Looks for Views/Demo/ShowView.cshtml
        }

    }
}