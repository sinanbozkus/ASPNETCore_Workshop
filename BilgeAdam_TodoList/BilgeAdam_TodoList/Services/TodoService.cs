using BilgeAdam_TodoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeAdam_TodoList.Services
{
    public class TodoService
    {
        private readonly List<Todo> _todoList;

        public TodoService()
        {
            _todoList = new List<Todo>();
        }

        public int Kaydet(FormViewModel viewModel)
        {
            int id = _todoList.Count == 0 ? 1 : (_todoList.Max(x => x.Id) + 1);

            var todo = new Todo
            {
                Id = id,
                Baslik = viewModel.Baslik,
                Aciklama = viewModel.Aciklama,
                Aktif = true,
                KayitTarihi = DateTime.Now
            };

            _todoList.Add(todo);

            return id;
        }

        public List<ListViewModel> Listele()
        {
            var viewModel = _todoList
                                 //.Where(x => x.Aktif == aktif)
                                 .Select(x => new ListViewModel
                                 {
                                     Id = x.Id,
                                     Baslik = x.Baslik,
                                     Aktif = x.Aktif,
                                     Tarih = x.GuncellenmeTarihi.HasValue ? x.GuncellenmeTarihi.Value : x.KayitTarihi
                                 })
                                 .ToList();

            return viewModel;
        }
    }
}
