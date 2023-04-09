using CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace CoffeeShopRegistration.Controllers
{
    public class Registration : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }



        [HttpPost]

        public IActionResult HandleSubmit(UserProfile userProfile)
        {
            // We can process the UserProfile object now
            // for example, we can save it do a database
            if (!ModelState.IsValid)
            {
                return View(userProfile);
            }
            return RedirectToAction("Welcome", userProfile);
        }

        public IActionResult Welcome(UserProfile userProfile) 
        { 
            return View(userProfile);
        }
    }
}
