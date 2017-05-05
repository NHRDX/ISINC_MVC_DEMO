using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISINC_Project.Models;
using System.Collections;

namespace ISINC_Project.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            //IEnumerable< Product pr> = null;

            IEnumerable<Product> Inventory;

            Product prod1 = new Product();
            prod1.ID = 1;
            prod1.Name = "Airplane";
            prod1.Price = 49.99M;
            prod1.Description = "It just flies";


            Product prod2 = new Product();
            prod2.ID = 1;
            prod2.Name = "Boat";
            prod2.Price = 39.99M;
            prod2.Description = "It just floats";
            


            
            //IEnumerable{ prod1; prod2 };


            // var IEnumerable<Product> = null;
            //create a collection of products 
            //... IEn


            //return it w the View method below
            return View( );
        }
    }
}