﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;



namespace ISINC_Project.Models
{
    [Table("Products")]

    public class Product
    {
        [Key]
        public int ID {get; set;}

        [Required]
        public String Name { get; set; }
        [Required]
        public decimal Price { get; set;}
        [Required]
        public String Description { get; set; }

        public virtual IQueryable<Review> Reviews { get; set; }



    }
}
