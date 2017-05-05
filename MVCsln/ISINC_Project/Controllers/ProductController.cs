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

            var prod1 = new { ID = 1, Name = "Airplane", Price = 49.99M, Description = "It just flies" };

            var prod2 = new { ID = 2, Name = "Boat", Price = 39.99M, Description = "It just floats" };
             
            //IEnumerable{ prod1; prod2 };


            // var IEnumerable<Product> = null;
            //create a collection of products 
            //... IEn


            //return it w the View method below
            return View( );
        }
    }
}