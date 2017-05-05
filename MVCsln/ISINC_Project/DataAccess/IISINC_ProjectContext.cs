using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ISINC_Project.Models;

namespace ISINC_Project.DataAccess
{
    public interface IISINC_ProjectContext
    {
        IQueryable<Product> GetAllProducts();
        IQueryable<Review> GetAllReviews();
        IQueryable<Reviewer> GetAllReviewers();

        void MarkAsModified(object obj);
        void MarkAsAdded(object obj);

        void SaveChanges();
    }
}