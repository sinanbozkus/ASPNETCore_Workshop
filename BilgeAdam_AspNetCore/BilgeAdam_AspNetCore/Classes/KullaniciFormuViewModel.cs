using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeAdam_AspNetCore.Classes
{
    public class KullaniciFormuViewModel
    {
        [Display(Name = "Adı")]
        public string Ad { get; set; }

        [Display(Name = "Soyadı")]
        public string Soyad { get; set; }

        [Display(Name = "Durumu")]
        public bool Aktif { get; set; }
    }
}
