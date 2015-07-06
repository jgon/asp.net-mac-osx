using System;
using Microsoft.AspNet.Mvc;

namespace WebApp2.Controllers
{
    ///
    // http://localhost:5001
    ///
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }

        public IActionResult Hello(string name)
        {
            ViewBag.Title = "Dedicated hello";
            ViewData["name"] = name;
            ViewData["timestamp"] = DateTime.Now;
            return View();
        }

        public string DefaultHello()
        {
            return "<h1>Running <b>ASP.NET 5</b> on Mac</h1>.";
        }
    }
}