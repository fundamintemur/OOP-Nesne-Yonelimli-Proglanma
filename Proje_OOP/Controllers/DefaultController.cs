using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Ornekler;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {
        //void Islemler()
        // {
        //     Class1 c = new Class1();
        //     c.Topla();
        // }

        void mesajlar()
        {
            ViewBag.m1 = "Merhaba bu bir core projesi";
            ViewBag.m2 = "merhaba bu proje çok iyi duruyor";
            ViewBag.m3 = "selamlar hi hey bonjour";
        }

        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;
            return sonuc;
                
        }
        int Cevre()
        {
            int kisa = 10;
            int uzun = 20;
            int sonuc = 2 * (kisa + uzun);
            return sonuc;
        }
        int faktoriyel()
        {
            int a = 7;
            int fak = 1;
           
            for (int x = 1; x <= a; x++)
            {
                //fak *= x;
                fak = fak * x;
                
            }
            return fak;
        }
        string cumle()
        {
            string s = "Merhaba Hi";
            return s;
        }
        void MesajListesi(string p)
        {
            ViewBag.v = p;
        }

        int Faktoriyel(int p)
        {
            int f = 1;
          for(int i = 1; i <= p; i++)
            {
                f = f * i;
            }
            return f;
        }
        int topla(int s1,int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }
        public IActionResult Index() 
        {
            mesajlar();
            MesajListesi("Merhaba Funda");
            ViewBag.t=topla(5, 6);
            return View();
        }
        public IActionResult Urunler()
        {
            mesajlar();
            ViewBag.t = topla();
            ViewBag.c = Cevre();
            ViewBag.fak = Faktoriyel(5);
            return View();
        }
        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();//sehirler classıno kullanabilmek için nesne türettim.
            //nesne içindeki prpertyleri çağırdım.
            
            sehirler.Ad = "Kiev";
            sehirler.Id = 1;
            sehirler.Nufus = 1000000;
            sehirler.Ulke = "Ukrayna";
            sehirler.Renk1 = "Mavi";
            sehirler.Renk2 = "Kırmızı";
            sehirler.Renk3 = "Beyaz";
            ViewBag.v1 = sehirler.Id;
            ViewBag.v2 = sehirler.Ad;
            ViewBag.v3 = sehirler.Nufus;
            ViewBag.v4 = sehirler.Ulke;
            //viewbag veri taşımak için kullanıyoruz.
            return View();
        }
    }
}
