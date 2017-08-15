using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeAdam_TodoList.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime? GuncellenmeTarihi { get; set; }
        public bool Aktif { get; set; }
        public string Aciklama { get; set; }
    }
}
