using Microsoft.AspNetCore.Mvc;
using MVC.Models.ViewModels;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> _products = new List<Product> {
            new Product{ Id= 1, Name ="Kalem" },
            new Product{ Id= 2, Name ="Silgi" },
            new Product{ Id= 3, Name ="Defter" },
            new Product{ Id= 4, Name ="Kitap" }
        };
        private static int _idCounter = 5;

        // Listeleme Sayfası
        public IActionResult Index()
        {
            return View(_products);
        }

        #region CREATE
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            model.Id = _idCounter;
            _idCounter++;
            _products.Add(model);
            return RedirectToAction("Index");
        }
        #endregion


        #region UPDATE
        public IActionResult Update(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product model)
        {
            var product = _products.FirstOrDefault(x => x.Id == model.Id);
            if (product != null)
            {
                product.Name = model.Name;
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region DELETE
        public IActionResult Delete(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product model)
        {
            var product = _products.FirstOrDefault(x => x.Id == model.Id);
            if (product != null)
            {
                _products.Remove(product);

            }
            return RedirectToAction("Index");
        }
        #endregion
    }
}
