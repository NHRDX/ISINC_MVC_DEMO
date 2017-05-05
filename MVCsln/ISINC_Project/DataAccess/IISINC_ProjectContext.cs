using ISINC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISINC_Project.DataAccess
{
    public interface IISINC_ProjectContext
    {
        IQueryable<Review> GetAllReviews();
        IQueryable<Product> GetAllProducts();
      

        void MarkAsModified(object obj);
        void MarkAsAdded(object obj);

        void SaveChanges();
    }
}