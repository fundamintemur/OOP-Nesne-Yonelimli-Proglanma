using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Entity;
using Proje_OOP.ProjeContext;

namespace Proje_OOP.Controllers
{
    public class ProductController1 : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Products.ToList();
            return View(values);
        }
        [HttpGet]
        //bu metotta ekleme sayfasına yönlediriyor
        //bu metod sayesinde sayfa ilk yüklediğinde göreceğimiz ekleme ekranı.
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            context.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(int id)
        {
            
            var value = context.Products.Where(x => x.Id == id).FirstOrDefault();
            //silinecek veriyi hafızaya aldık.
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = context.Products.Where(x => x.Id == id).FirstOrDefault();
            
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product p)

        {
            var value = context.Products.Where(x => x.Id ==p.Id).FirstOrDefault();
            value.Name = p.Name;
            value.Price = p.Price;
            value.Stock = p.Stock;
            context.SaveChanges();
            
            
            return RedirectToAction("Index");
        }
    }
}
