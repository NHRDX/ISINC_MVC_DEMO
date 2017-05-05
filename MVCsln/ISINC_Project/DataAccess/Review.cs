using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleDataAccess.Models
{
    [Table("Reviews")]
    public class Review
    {
        [Key]
        public int ID { get; set; }

        public String Content { get; set; }

        public Product Product { get; set; }

    }
}
 