using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BilgeAdam_AspNetCore.Controllers
{
    public class HomeController : Controller
    {
        //[Route("anasayfa")]
        public IActionResult Index()
        {
            //dynamic metin = "metin";
            //metin = 3;


            //ViewBag.WebSitesi = "http://www.bilgeadam.com";

            //ViewData["WebSitesi"] = "http://www.bilgeadam.com";

            TempData["WebSitesi"] = "http://www.bilgeadam.com";

            return View();
        }

        //[Route("hakkinda")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
