using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          
            List<Class> p = new List<Class>();

            p.Add(new Class { Id = 100,katagori="gıda", urunAdi = "Karam", Fiyat = 3 });
            p.Add(new Class { Id = 101, katagori = "gıda", urunAdi = "Dido", Fiyat = 2 });
            p.Add(new Class { Id = 102, katagori = "gıda", urunAdi = "Caramio", Fiyat = 5 });
            p.Add(new Class { Id = 103, katagori = "gıda", urunAdi = "Piko", Fiyat = 1 });
            p.Add(new Class { Id = 104, katagori = "gıda", urunAdi = "Çokonat", Fiyat = 4 });
            p.Add(new Class { Id = 105, katagori = "gıda", urunAdi = "Albeni", Fiyat = 6 });
            p.Add(new Class { Id = 106, katagori = "kozmetik", urunAdi = "far", Fiyat = 15 });
            p.Add(new Class { Id = 107, katagori = "giyim", urunAdi = "eldiven", Fiyat = 20 });
            p.Add(new Class { Id = 108, katagori = "içecek", urunAdi = "pepsi", Fiyat = 5 });
            p.Add(new Class { Id = 109, katagori = "oyuncak", urunAdi = "oyuncak araba", Fiyat = 50 });
            p.Add(new Class { Id = 110, katagori = "giyim", urunAdi = "şapka", Fiyat = 40 });
            p.Add(new Class { Id = 111, katagori = "içecek", urunAdi = "fanta", Fiyat = 6 });




            var result =p.OrderBy(a => a.Fiyat).ToList();
          
            return View(p.ToList());

        }
    }
}