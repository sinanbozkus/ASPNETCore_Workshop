using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeAdam_TodoList.Models
{
    public class FormViewModel : BaseViewModel
    {
        [Display(Name = "Başlık")]
        public string Baslik { get; set; }

        [Display(Name = "Kayıt Tarihi")]
        public DateTime KayitTarihi { get; set; }

        [Display(Name = "Güncellenme Tarihi")]
        public DateTime? GuncellenmeTarihi { get; set; }

        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }


        public bool IsNew
        {
            get
            {
                if (Id == 0)
                    return true;
                else
                    return false;
            }
        }

        //public bool IsNew => Id == 0 ? true : false;
    }
}
