using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBoilerplate.Controllers
{
   public class HomeController : Controller
    {
        // --------------------------------------------------------------------//
        // INDEX VIEW
        // --------------------------------------------------------------------//
        public IActionResult Index()
        {
            return View();
        }

        // --------------------------------------------------------------------//
        // COMPONENTS
        // --------------------------------------------------------------------//

        public IActionResult Dropdown()
        {
            ViewData["Message"] = "Dropdown.";

            return View();
        }

        public IActionResult Search()
        {
            ViewData["Message"] = "Search.";

            return View();
        }

        public IActionResult Product()
        {
            ViewData["Message"] = "Search.";

            return View();
        }

        public IActionResult Cards()
        {
            ViewData["Message"] = "Cards.";

            return View();
        }

        public IActionResult Table()
        {
            ViewData["Message"] = "Cards.";

            return View();
        }

        public IActionResult Forms()
        {
            ViewData["Message"] = "Forms.";

            return View();
        }

        public IActionResult Modal()
        {
            ViewData["Message"] = "Modal.";

            return View();
        }

        // --------------------------------------------------------------------//
        // SECTIONS
        // --------------------------------------------------------------------//

        public IActionResult Cta()
        {
            ViewData["Message"] = "Cta.";

            return View();
        }

        public IActionResult Icons()
        {
            ViewData["Message"] = "Icons.";

            return View();
        }

        public IActionResult LargeIcons()
        {
            ViewData["Message"] = "Icons.";

            return View();
        }

        public IActionResult Faq()
        {
            ViewData["Message"] = "Icons.";

            return View();
        }

        public IActionResult LargeImage()
        {
            ViewData["Message"] = "Image.";

            return View();
        }

        public IActionResult Image()
        {
            ViewData["Message"] = "Image.";

            return View();
        }

        public IActionResult Testimonials()
        {
            ViewData["Message"] = "Testimonials";

            return View();
        }

        // --------------------------------------------------------------------//
        // ERROR HANDLING
        // --------------------------------------------------------------------//
        public IActionResult Error()
        {
            return View();
        }
    }
}
