using Microsoft.AspNetCore.Mvc;
using StoreApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace StoreApp.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UserController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }


        [HttpPost]
        public IActionResult Delete(string userId)
        {
            var user = _userManager.FindByIdAsync(userId).Result;
            if (user != null)
            {
                var result = _userManager.DeleteAsync(user).Result;
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                }
            }
            else
            {
                // send a message if user could not be found.
                ModelState.AddModelError("", "Kullanıcı bulunamadı.");
            }

            return RedirectToAction("Index");
        }

    }
}