using ISINC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISINC_Project.DataAccess
{
    public interface IProductDBContext
    {
        IQueryable<Product> GetAllProducts();
        IQueryable<Review> GetAllReviews();
        IQueryable<Reviewer> GetAllReviewers();

        void MarkAsModified(object obj);
        void MarkAsAdded(object obj);

        void SaveChanges();
    }
}