using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ConsoleDataAccess.Models;



namespace ConsoleDataAccess.Models
{
    [Table("Products")]

    public class Product
    {
        [Key]
        public int ID {get; set;}

        public String Name { get; set; }

        public decimal Price { get; set;}

        public virtual IQueryable<Review> Reviews { get; set; }



    }
} 
