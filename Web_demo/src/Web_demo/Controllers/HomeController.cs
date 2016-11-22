using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web_demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is about page";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "This is contact page!";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
