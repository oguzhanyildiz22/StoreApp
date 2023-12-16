using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {

        private readonly RepositoryContext _context;

        public ProductController(RepositoryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var model = _context.Products.ToList();
            return View(model);
        }

        public IActionResult Get(int id)
        {
            Product product = _context.Products.First(p => p.ProductId.Equals(id));
            return View(product);
        }

        public IActionResult SortByNameAscending()
        {
            var products = _context.Products.OrderBy(p => p.ProductName).ToList();
            return View("Index", products);
        }

        public IActionResult SortByNameDescending()
        {
            var products = _context.Products.OrderByDescending(p => p.ProductName).ToList();
            return View("Index", products);
        }

        public IActionResult SortByAddedDateAscending()
        {
            var products = _context.Products.OrderBy(p => p.AddedDate).ToList();
            return View("Index", products);
        }

        public IActionResult SortByAddedDateDescending()
        {
            var products = _context.Products.OrderByDescending(p => p.AddedDate).ToList();
            return View("Index", products);
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            // ProductId'nin benzersiz olup olmadığını kontrol et
            var existingProduct = _context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (existingProduct != null)
            {
                ModelState.AddModelError("ProductId", "A product with the same ProductId already exists.");
            }

            if (ModelState.IsValid)
            {
                // Validation başarılı, ürünü ekleyebiliriz
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            // Validation başarısız, formu tekrar göster
            return View(product);
        }


        public IActionResult Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == id);

            if (product == null)
            {
                return NotFound(); // Ürün bulunamazsa 404 hatası döndür
            }

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == id);

            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }


    }

}