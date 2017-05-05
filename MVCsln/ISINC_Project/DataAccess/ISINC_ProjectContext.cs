using ISINC_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ISINC_Project.DataAccess
{
    public class ISINC_ProjectContext : DbContext, IISINC_ProjectContext
    {
        public ISINC_ProjectContext(string connStr, bool useProxies = true)
            : base(connStr) 
        {
            Configuration.ProxyCreationEnabled = useProxies;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        public IQueryable<Product> GetAllProducts()
        {
            return Products;
        }

        public IQueryable<Reviewer> GetAllReviewers()
        {
            return Reviewers;
        }

        public IQueryable<Review> GetAllReviews()
        {
            return Reviews;
        }

        public void MarkAsModified(object obj)
        {
            Entry(obj).State = EntityState.Modified;
        }

        public void MarkAsAdded(object obj)
        {
            Entry(obj).State = EntityState.Added;
        }

        void IISINC_ProjectContext.SaveChanges()
        {
            SaveChanges();
        }
    }
}