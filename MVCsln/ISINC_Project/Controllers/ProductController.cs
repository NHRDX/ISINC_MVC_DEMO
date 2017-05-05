using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISINC_Project.Models;
using System.Configuration;
using ISINC_Project.DataAccess;
using Socrates.DataAccess;


namespace ISINC_Project.Controllers
{
    public class ProductController : Controller
    {
        protected IISINC_ProjectContext context;
        // GET: Product
        public ActionResult Index()
        {



            Product p = new Product() { ID = 1, Name = "Laptop i5", Description = "Best of best", Price = 200M };
            Product p2 = new Product() { ID = 2, Name = "Computer", Description = "i5 8gb ram", Price = 300M };
            Product p3 = new Product() { ID = 3, Name = "Laptop i7", Description = "Best of best", Price = 500M };

            List<Product> products = new List<Product>();
            products.Add(p);
            products.Add(p2);
            products.Add(p3);


            return View(products);
        }

        public ActionResult Details(int id)
        {
            Product p = new Product() { ID = 1, Name = "Laptop i5", Description = "Best of best", Price = 200M };

            return View(p);
        }

        public ActionResult Edit(int id)
        {
            Product p = new Product() { ID = 1, Name = "Laptop i5", Description = "Best of best", Price = 200M };

            return View(p);
        }
    }
}