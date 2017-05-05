using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;




namespace ISINC_Project.Models
{
    [Table("Reviews")]
    public class Review
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public String Content { get; set; }
        [Required]
        public Product Product { get; set; }
        public Reviewer Reviewer { get; set; }

    }
}
