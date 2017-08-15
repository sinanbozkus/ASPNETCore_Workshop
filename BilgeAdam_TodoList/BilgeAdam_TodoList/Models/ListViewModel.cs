using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeAdam_TodoList.Models
{
    public class ListViewModel : BaseViewModel
    {
        [Display(Name = "Başlık")]
        public string Baslik { get; set; }

        [Display(Name = "Tarih")]
        public DateTime Tarih { get; set; }
    }
}
