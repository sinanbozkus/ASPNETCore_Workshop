using BilgeAdam_AspNetCore.Classes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeAdam_AspNetCore.ViewComponents
{
    //[ViewComponent(Name = "Haberler")]
    [ViewComponent]
    public class DuyuruViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //await Task.CompletedTask;

            var list = new List<Duyuru>();

            list.Add(new Duyuru {
                Başlık = "Duyuru 1",
                Tarih = DateTime.Now.AddDays(-2)
            });

            list.Add(new Duyuru
            {
                Başlık = "Duyuru 2",
                Tarih = DateTime.Now.AddDays(-1)
            });

            list.Add(new Duyuru
            {
                Başlık = "Duyuru 3",
                Tarih = DateTime.Now
            });

            return View(list);

            // return View("Kategoriler", list);
        }
    }
}
