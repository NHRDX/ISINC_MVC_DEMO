using ISINC_Project.DataAccess;
using ISINC_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Socrates.DataAccess
{
    public class SocratesContext : DbContext, IISINC_ProjectContext
    {
        public SocratesContext(string connStr, bool useProxies = true)
            : base(connStr) 
        {
            Configuration.ProxyCreationEnabled = useProxies;
        }

        public DbSet<Review> Reviews { get; set; }
    
        public DbSet<Product> Products { get; set; }

        public IQueryable<Review> GetAllReviews()
        {
            return Reviews;
        }

        public IQueryable<Product> GetAllProducts()
        {
            return Products;
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