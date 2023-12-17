using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        public IActionResult Index()
        {
            var model = _context.Products.ToList();
            return View(model);
        }

        [Authorize]
        public IActionResult Get(int id)
        {
            Product product = _context.Products.First(p => p.ProductId.Equals(id));
            return View(product);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(Product product)
        {
            // ProductId alanını elle set etme, veritabanındaki otomatik artan sıraya bırak
            product.ProductId = 0; // 0 ataması, veritabanında otomatik artan bir sıraya sahip olduğunu gösterir

            // ProductId'nin benzersiz olup olmadığını kontrol et
            var existingProduct = _context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (existingProduct != null)
            {
                ModelState.AddModelError("ProductId", "A product with the same ProductId already exists.");
            }

            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
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

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == id);

            if (product == null)
            {
                return NotFound(); // Ürün bulunamazsa 404 hatası döndür
            }

            return View(product);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(Product updatedProduct)
        {
            // ProductId'nin benzersiz olup olmadığını kontrol et
            var existingProduct = _context.Products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);
            if (existingProduct != null)
            {
                ModelState.AddModelError("ProductId", "A product with the same ProductId already exists.");
            }

            if (ModelState.IsValid)
            {
                // Validation başarılı, güncellenecek ürünü veritabanından al
                var productToUpdate = _context.Products.Find(updatedProduct.ProductId);

                if (productToUpdate != null)
                {
                    // Veritabanından alınan ürünü güncelle
                    productToUpdate.ProductName = updatedProduct.ProductName;
                    productToUpdate.Price = updatedProduct.Price;
                    productToUpdate.Quantity = updatedProduct.Quantity;

                    // Güncelleme işlemini kaydet
                    _context.SaveChanges();

                    TempData["UpdateSuccess"] = true; // Güncelleme başarılı olduğunu belirtmek için TempData kullanılıyor
                    return RedirectToAction("Index");
                }
                else
                {
                    // Güncellenecek ürün bulunamadı
                    return NotFound();
                }
            }

            // Validation başarısız, formu tekrar göster
            return View(updatedProduct);
        }


        [HttpGet]
        public IActionResult UpdateSuccess()
        {
            return View();
        }



    }
}
