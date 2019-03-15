using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JQueryMVCApplication.Models;

namespace JQueryMVCApplication.Controllers
{


    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public JsonResult ProductList()
        {
            List<Product> products = new List<Product>();
            Product product = new Product()
                                { Id = 1, Name = "Mobile Phone", ImageUrl = "~/mobile.jpg" };
            products.Add(product);

            product = new Product()
                        { Id = 2, Name = "Tab", ImageUrl = "~/tab.jpg" };
            products.Add(product);

            product = new Product()
                        { Id = 3, Name = "Laptop", ImageUrl = "~/laptop.jpg" };
            products.Add(product);

            JsonResult data = Json(products);

            return data;
        }








        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
