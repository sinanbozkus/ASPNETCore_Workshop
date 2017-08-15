using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BilgeAdam_AspNetCore.Classes;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BilgeAdam_AspNetCore.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var kullanici = new KullaniciViewModel()
            {
                AdSoyad = "Sinan Bozkuş"
            };

            return View(kullanici);
        }

        public IActionResult Yeni()
        {
            return View("KullaniciFormu");
        }

        [HttpPost]
        public IActionResult Kaydet(KullaniciFormuViewModel formData)
        {
            return new EmptyResult();
        }

        public string Merhaba()
        {
            string cevap = "Merhaba Dünya!";
            return cevap;
        }

        public JsonResult Listele()
        {
            var liste = new List<string> { "bir", "iki", "üç" };
            return Json(liste);
        }
    }
}
