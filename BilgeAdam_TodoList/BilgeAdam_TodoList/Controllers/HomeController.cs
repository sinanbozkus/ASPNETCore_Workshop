using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BilgeAdam_TodoList.Models;
using BilgeAdam_TodoList.Services;

namespace BilgeAdam_TodoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly TodoService _todoService;

        public HomeController(TodoService todoService)
        {
            _todoService = todoService;
            //_todoService = new TodoService();
        }

        public IActionResult Index()
        {
            var list = _todoService.Listele();

            return View(list);
        }

        public IActionResult Yeni()
        {
            return View("Form", new FormViewModel());
        }

        public IActionResult Duzenle()
        {
            return new EmptyResult();
        }

        public IActionResult Sil()
        {
            return new EmptyResult();
        }

        public IActionResult Kaydet(FormViewModel formData)
        {
            _todoService.Kaydet(formData);

            return RedirectToAction(nameof(Index));
        }
    }
}
