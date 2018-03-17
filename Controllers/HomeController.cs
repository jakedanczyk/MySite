using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mysite.Models;

namespace mysite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["Product"] = "Smartphone";

            var model = new ProductViewModel()
            {
                Name = "phone",
                Price = 100f
            };

            return View(model);
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            return View(new ProductViewModel());
        }

        [HttpPost]
        public ActionResult AddProduct(ProductViewModel model)
        {
            if (ModelState.IsValid)
                ViewBag.Result = "Prodct was added succesfully";
            return View(new ProductViewModel());
        }
    }
}   