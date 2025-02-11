using dotnetShop.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace dotnetShop.Controllers
{
    public class ShopController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        // Our Code

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult AddEditProductListing()
        {
            return View();
        }

        public IActionResult AddEditProductListingForm()
        {
            return RedirectToAction("Index");
        }

        //

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
