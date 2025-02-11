using dotnetShop.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace dotnetShop.Controllers
{
    public class ShopController : Controller
    {

        private readonly ProductsDbContext _context;

        public ShopController(ProductsDbContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allListings = _context.Products.ToList();


            return View(allListings);
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

        public IActionResult AddEditProductListingForm(Product item)
        {
            if(item.Id == 0)
            {
                _context.Products.Add(item);
            }
            else
            {
                _context.Products.Update(item);
            }

            _context.SaveChanges();

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
